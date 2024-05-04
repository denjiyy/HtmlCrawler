using CrawlerHTML;
using CrawlerHTML.CustomDataStructures;

namespace HtmlCrawl.HtmlCrawler
{
    // always begin the relative path with "//root..." (HtmlTreeNode's argument)
    public class HtmlSearch
    {
        public HtmlTreeNode Root { get; }

        public HtmlSearch(HtmlTreeNode root)
        {
            Root = root;
        }

        public CustomList<HtmlTreeNode> Find(string path)
        {
            string[] pathParts = path.CustomSplit("/").CustomWhere(s => !CustomLinqExtensions.CustomIsNullOrEmpty(s)).ToArray();

            bool startFromRoot = path.CustomStartsWith("//");
            int startIndex = startFromRoot ? 0 : 1;

            if (startFromRoot)
            {
                pathParts = pathParts.CustomSkip(1).ToArray();
                return Find(Root, pathParts, startIndex);
            }
            else
            {
                return Find(null!, pathParts, startIndex);
            }
        }

        private CustomList<HtmlTreeNode> Find(HtmlTreeNode node, string[] path, int index)
        {
            if (node == null)
            {
                return new CustomList<HtmlTreeNode>();
            }

            if (index == path.Length)
            {
                return new CustomList<HtmlTreeNode> { node };
            }

            string currentPath = path[index];

            if (currentPath == "//")
            {
                CustomList<HtmlTreeNode> result = new CustomList<HtmlTreeNode>
                {
                    node
                };

                foreach (HtmlTreeNode child in node.Children)
                {
                    result.AddRange(Find(child, path, index + 1).ToArray());
                }

                return result;
            }
            if (currentPath.CustomContains("[@")) // when entering the relative path do as follows: ".../table[@id=table2]..." or ".../p[@id=p3]..." without ''
            {
                int openingBracketIndex = currentPath.CustomIndexOfString("[@");
                int closingBracketIndex = currentPath.CustomIndexOfString("]", openingBracketIndex);

                if (openingBracketIndex != -1 && closingBracketIndex != -1)
                {
                    string tag = currentPath.CustomSubstring(0, openingBracketIndex);
                    string attributeValueString = currentPath.CustomSubstring(openingBracketIndex + 2, closingBracketIndex - openingBracketIndex - 2);

                    string[] parts = attributeValueString.CustomSplit("=");

                    if (parts.Length == 2)
                    {
                        string attribute = parts[0];
                        string value = parts[1];

                        HtmlTreeNode[] matchingChildren = node.Children
                            .CustomWhere(child => child.Tag == tag && child.Attributes.ContainsKey(attribute) && child.Attributes[attribute] == value)
                            .ToArray();

                        CustomList<HtmlTreeNode> result = new CustomList<HtmlTreeNode>();
                        foreach (HtmlTreeNode child in matchingChildren)
                        {
                            result.AddRange(Find(child, path, index + 1).ToArray());
                        }

                        return result;
                    }
                }
            }
            else if (currentPath == "div")
            {
                HtmlTreeNode[] matchingChildren = node.Children.CustomWhere(child => child.Tag == "div").ToArray();
                CustomList<HtmlTreeNode> result = new CustomList<HtmlTreeNode>();
                foreach (HtmlTreeNode child in matchingChildren)
                {
                    result.AddRange(Find(child, path, index + 1).ToArray());
                }

                return result;
            }
            else if (currentPath.CustomContains("["))
            {
                int tagStartIndex = 0;
                int tagEndIndex = currentPath.CustomIndexOf('[');
                string tag = currentPath.CustomSubstring(tagStartIndex, tagEndIndex - tagStartIndex);

                int indexStartIndex = tagEndIndex + 1;
                int indexEndIndex = currentPath.CustomIndexOf(']', indexStartIndex, currentPath.Length - indexStartIndex);
                string indexValue = currentPath.CustomSubstring(indexStartIndex, indexEndIndex - indexStartIndex);

                if (int.TryParse(indexValue, out int indexIntValue))
                {
                    CustomList<HtmlTreeNode> matchingChildren = new CustomList<HtmlTreeNode>(node.Children.CustomWhere(child => child.Tag == tag));
                    if (indexIntValue >= 1 && indexIntValue <= matchingChildren.Count)
                    {
                        CustomList<HtmlTreeNode> result = Find(matchingChildren[indexIntValue - 1], path, index + 1);
                        return result.Count != 0 ? result : Find(node, path, index + 1);
                    }
                }
            }
            else if (currentPath == "*")
            {
                CustomList<HtmlTreeNode> result = new CustomList<HtmlTreeNode>();
                foreach (HtmlTreeNode child in node.Children)
                {
                    result.AddRange(Find(child, path, index + 1).ToArray());
                }
                return result;
            }
            else
            {
                HtmlTreeNode[] matchingChildren = node.Children.CustomWhere(child => child.Tag == currentPath).ToArray();
                CustomList<HtmlTreeNode> result = new CustomList<HtmlTreeNode>();
                foreach (HtmlTreeNode child in matchingChildren)
                {
                    result.AddRange(Find(child, path, index + 1).ToArray());
                }
                return result;
            }

            return new CustomList<HtmlTreeNode>();
        }
    }
}