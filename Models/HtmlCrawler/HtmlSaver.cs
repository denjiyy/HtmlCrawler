using HTML.Models.CustomStringBuilder;
using CrawlerHTML;

namespace HtmlCrawl
{
    public class HtmlSaver
    {
        private HtmlTreeNode treeNode;

        public HtmlSaver(HtmlTreeNode treeNode)
        {
            this.treeNode = treeNode;
        }

        public void SaveHtmlFile(string filePath)
        {
            CustomStringBuilder result = new CustomStringBuilder();
            SaveNode(treeNode, result, 0);

            File.WriteAllText(filePath, result.ToString().CustomTrim());
        }

        private void SaveNode(HtmlTreeNode node, CustomStringBuilder result, int indentationLevel)
        {
            result.Append(new string(' ', indentationLevel * 4));
            result.Append($"<{node.Tag}");

            foreach (var attribute in node.Attributes)
            {
                result.Append($" {attribute.Key}=\"{attribute.Value}\"");
            }

            result.Append(">");

            if (!CustomLinqExtensions.CustomIsNullOrEmpty(node.Content))
            {
                result.Append(node.Content.CustomTrimStart());
            }

            foreach (var child in node.Children)
            {
                result.Append("\n");
                SaveNode(child, result, indentationLevel + 1);
            }

            if (node.Children.Count > 0)
            {
                result.Append(new string(' ', indentationLevel * 4));
            }

            result.Append($"</{node.Tag}>\n");
        }
    }
}