using CrawlerHTML.CustomDataStructures;

namespace HtmlCrawl
{
    public class HtmlTreeNode
    {
        public string Tag { get; }
        public CustomList<HtmlTreeNode> Children { get; }
        public string Content { get; private set; }
        public CustomDictionary<string, string> Attributes { get; private set; }

        //public HtmlTreeNode Parent { get; set; } vse taq

        public HtmlTreeNode(string tag, string content)
        {
            Tag = tag;
            Children = new CustomList<HtmlTreeNode>();
            Content = content;
            Attributes = new CustomDictionary<string, string>();
        }
    }
}
