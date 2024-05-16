using CrawlerHTML.CustomDataStructures;
using HtmlCrawl;
using System.Diagnostics;
using CrawlerHTML;

namespace HTML.Models.Windows
{
    public partial class SearchResultWindow : Form
    {
        private HtmlTreeNode root;
        public SearchResultWindow(HtmlTreeNode root, CustomList<HtmlTreeNode> searchResults, string relativePath)
        {
            InitializeComponent();

            this.root = root;

            DisplaySearchResults(searchResults, relativePath);
        }

        private void DisplaySearchResults(CustomList<HtmlTreeNode> searchResults, string relativePath)
        {
            if (relativePath == "//")
            {
                DisplayTextContent(root);
            }
            else if (relativePath.EndsWithCustom("/div") && CountDivSegments(relativePath) == 1)
            {
                DisplayDivContent(root);
            }
            else if (searchResults != null && searchResults.Count != 0)
            {
                foreach (var node in searchResults)
                {
                    if (node.Content != null)
                    {
                        ResultsListBox.Items.Add(node.Content);
                    }
                }
            }
            else
            {
                ResultsListBox.Items.Add("No results found. Is the relative path entered correctly?");
            }
        }

        private void DisplayTextContent(HtmlTreeNode node)
        {
            if (!CustomLinqExtensions.CustomIsNullOrEmpty(node.Content))
            {
                if (node.Tag == "a" && node.Attributes.ContainsKey("href"))
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Text = node.Content;
                    linkLabel.Tag = node.Attributes["href"];
                    linkLabel.LinkClicked += LinkLabel_LinkClicked!;

                    linkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

                    linkLabel.Dock = DockStyle.None;

                    linkLabel.Location = new Point(0, ResultsListBox.Height - linkLabel.Height);

                    ResultsListBox.Controls.Add(linkLabel);
                }
                else
                {
                    ResultsListBox.Items.Add(node.Content);
                }
            }

            foreach (var child in node.Children)
            {
                DisplayTextContent(child);
            }
        }

        private void DisplayDivContent(HtmlTreeNode node)
        {
            if (node.Tag == "div")
            {
                ResultsListBox.Items.Add($"<{node.Tag}>");
                DisplayTextContent(node);
                ResultsListBox.Items.Add($"</{node.Tag}>");
            }

            foreach (var child in node.Children)
            {
                DisplayDivContent(child);
            }
        }

        private int CountDivSegments(string path)
        {
            int count = 0;
            int index = -1;

            while ((index = path.CustomIndexOfString("/div", index + 1)) != -1)
            {
                count++;
            }

            return count;
        }


        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            string url = (string)linkLabel.Tag!;

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening link: {ex.Message}");
                throw;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
