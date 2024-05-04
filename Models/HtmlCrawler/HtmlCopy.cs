using CrawlerHTML.CustomDataStructures;
using HtmlCrawl.Contracts;

namespace HtmlCrawl.HtmlCrawler
{
    public class HtmlCopy : IHtmlOperation
    {
        private readonly HtmlSearch htmlSearch;

        public HtmlCopy(HtmlSearch htmlSearch)
        {
            this.htmlSearch = htmlSearch;
        }

        public void PerformOperation(string sourcePath, string destinationPath)
        {
            CustomList<HtmlTreeNode> sourceNodes = htmlSearch.Find(sourcePath);
            CustomList<HtmlTreeNode> destinationNodes = htmlSearch.Find(destinationPath);

            foreach (HtmlTreeNode destinationNode in destinationNodes)
            {
                CopyContent(sourceNodes, destinationNode);
            }
        }

        private void CopyContent(CustomList<HtmlTreeNode> sourceNodes, HtmlTreeNode destinationNode)
        {
            foreach (var sourceNode in sourceNodes)
            {
                CopyNodeContent(sourceNode, destinationNode);
            }
        }

        private void CopyNodeContent(HtmlTreeNode sourceNode, HtmlTreeNode destinationNode)
        {
            destinationNode.Content = sourceNode.Content;

            //destinationNode.Attributes = sourceNode.Attributes;

            for (int i = 0; i < Math.Min(sourceNode.Children.Count, destinationNode.Children.Count); i++)
            {
                CopyNodeContent(sourceNode.Children[i], destinationNode.Children[i]);
            }
        }
    }
}