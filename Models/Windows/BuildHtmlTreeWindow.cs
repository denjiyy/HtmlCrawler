using CrawlerHTML;
using HtmlCrawl;
using HtmlCrawl.HtmlCrawler;

namespace HTML.Models.Windows
{
    public partial class BuildHtmlTreeWindow : Form
    {
        private HtmlTreeNode root;

        public BuildHtmlTreeWindow(HtmlTreeNode root)
        {
            InitializeComponent();
            this.root = root;
        }

        private void BuildTreeButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextBox.Text;

            if (!CustomLinqExtensions.CustomIsNullOrEmpty(filePath))
            {
                try
                {
                    string htmlContent = File.ReadAllText(filePath);

                    HtmlParser htmlParser = new HtmlParser();
                    root = htmlParser.BuildTreeFromHtml(htmlContent);

                    this.Hide();

                    HtmlCrawlerWindow htmlCrawlerWindow = new HtmlCrawlerWindow(root);
                    htmlCrawlerWindow.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading HTML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuitBuildTree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}