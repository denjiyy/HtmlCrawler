using CrawlerHTML;
using CrawlerHTML.CustomDataStructures;

namespace HtmlCrawl.HtmlCrawler
{
    public class HtmlParser
    {
        public HtmlTreeNode BuildTreeFromHtml(string html)
        {
            HtmlTreeNode root = new HtmlTreeNode("root", null!);
            CustomStack<HtmlTreeNode> stack = new CustomStack<HtmlTreeNode>();
            stack.Push(root);

            ProcessHtml(html, stack);

            return root;
        }

        private void ProcessHtml(string html, CustomStack<HtmlTreeNode> stack)
        {
            int index = 0;
            while (index < html.Length)
            {
                if (html[index] == '<')
                {
                    bool isClosingTag = false;
                    if (index + 1 < html.Length && html[index + 1] == '/')
                    {
                        isClosingTag = true;
                        index++;
                    }

                    int tagEnd = html.CustomIndexOfString(">", index);
                    if (tagEnd != -1)
                    {
                        string tag = html.CustomSubstring(index + 1, tagEnd - index - 1);
                        index = tagEnd + 1;

                        if (!isClosingTag)
                        {
                            ProcessOpeningTag(tag, stack);
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    int textEnd = html.CustomIndexOfString("<", index);
                    if (textEnd != -1)
                    {
                        string text = html.CustomSubstring(index, textEnd - index);
                        index = textEnd;
                        ProcessText(text, stack.Peek());
                    }
                    else
                    {
                        string text = html.CustomSubstring(index);
                        ProcessText(text, stack.Peek());
                        break;
                    }
                }
            }
        }

        private void ProcessOpeningTag(string tag, CustomStack<HtmlTreeNode> stack)
        {
            HtmlTreeNode newNode = CreateNodeFromTag(tag);
            stack.Peek().Children.Add(newNode);

            if (!tag.CustomEndsWith("/"))
            {
                stack.Push(newNode);
            }
        }

        private void ProcessText(string text, HtmlTreeNode parent)
        {
            if (!CustomLinqExtensions.CustomIsNullOrWhiteSpace(text))
            {
                if (parent.Content == null)
                {
                    parent.Content = text;
                }
                else
                {
                    parent.Content += text;
                }
            }
        }

        private HtmlTreeNode CreateNodeFromTag(string tag)
        {
            int spaceIndex = tag.CustomIndexOf(' ');
            string tagName = (spaceIndex == -1) ? tag : tag.CustomSubstring(0, spaceIndex);

            CustomDictionary<string, string> attributes = new CustomDictionary<string, string>();
            if (spaceIndex != -1)
            {
                string attrText = tag.CustomSubstring(spaceIndex + 1);
                ExtractAttributes(attrText, attributes);
            }

            return new HtmlTreeNode(tagName, null!) { Attributes = attributes };
        }

        private void ExtractAttributes(string attrText, CustomDictionary<string, string> attributes)
        {
            int index = 0;
            while (index < attrText.Length)
            {
                while (index < attrText.Length && CustomLinqExtensions.CustomIsWhiteSpace(attrText[index]))
                {
                    index++;
                }

                int equalsIndex = attrText.CustomIndexOfString("=", index);
                if (equalsIndex != -1)
                {
                    string attributeName = attrText.CustomSubstring(index, equalsIndex - index).CustomTrim();
                    index = equalsIndex + 1;

                    if (index < attrText.Length)
                    {
                        char quote = attrText[index];
                        int valueEndIndex = attrText.CustomIndexOf(quote, index + 1);
                        if (valueEndIndex != -1)
                        {
                            string attributeValue = attrText.CustomSubstring(index + 1, valueEndIndex - index - 1);
                            attributes[attributeName] = attributeValue;
                            index = valueEndIndex + 1;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}