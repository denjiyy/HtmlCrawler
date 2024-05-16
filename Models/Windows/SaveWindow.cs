using CrawlerHTML;
using HtmlCrawl;

namespace HTML.Models.Windows
{
    public partial class SaveWindow : Form
    {
        private HtmlTreeNode root;
        private HtmlSaver saver;

        public SaveWindow(HtmlTreeNode root)
        {
            InitializeComponent();

            this.root = root;
            saver = new HtmlSaver(root);
        }

        private void BackLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void SaveDocument_Click(object sender, EventArgs e)
        {
            string filePath = RelativePathTextBox.Text;

            if (CustomLinqExtensions.CustomIsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please enter a valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                saver.SaveHtmlFile(filePath);

                MessageBox.Show("HTML file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving HTML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }
    }
}
