using HtmlCrawl;
using HtmlCrawl.HtmlCrawler;

namespace HTML
{
    public partial class CopyWindow : Form
    {
        private HtmlTreeNode root;
        private HtmlCopy copy;
        private HtmlSearch search;

        public CopyWindow(HtmlTreeNode root)
        {
            InitializeComponent();

            this.root = root;

            search = new HtmlSearch(root);
            copy = new HtmlCopy(search);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string sourcePath = RelativePath.Text;
            string targetPath = TargetPath.Text;

            try
            {
                copy.PerformOperation(sourcePath, targetPath);
                MessageBox.Show("Copied successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying nodes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HtmlCrawlerWindow htmlCrawlerWindow = new HtmlCrawlerWindow(root);
            this.Hide();
            htmlCrawlerWindow.Show();
        }
    }
}
