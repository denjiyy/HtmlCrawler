using HTML.Models.Windows;
using HtmlCrawl;
using System.Diagnostics;
using CrawlerHTML;

namespace HTML
{
    public partial class HtmlCrawlerWindow : Form
    {
        // za da se vizualizirat pravilno kartinkite tryabva da sa v papkata HtmlExamples
        private const string htmlFolderPath = @"../../../Models/HtmlExamples/";
        private HtmlTreeNode root;
        private ListBox listBox;
        private PictureBox pictureBox;

        public HtmlCrawlerWindow(HtmlTreeNode root)
        {
            InitializeComponent();
            this.root = root;

            listBox = new ListBox();
            listBox.Dock = DockStyle.Top;
            listBox.Height = 210;

            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Bottom;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Height = 700;

            this.Controls.Add(listBox);
            this.Controls.Add(pictureBox);

            LoadTreeElements();
            DisplayImages(root, htmlFolderPath);
        }

        private void LoadTreeElements()
        {
            listBox.Items.Clear();

            DisplayTextContent(root);
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

                    linkLabel.Location = new Point(0, listBox.Height - linkLabel.Height);

                    listBox.Controls.Add(linkLabel);
                }
                else
                {
                    listBox.Items.Add(node.Content);
                }
            }

            foreach (var child in node.Children)
            {
                DisplayTextContent(child);
            }
        }

        private void DisplayImages(HtmlTreeNode node, string htmlFolderPath)
        {
            if (node.Tag == "img" && node.Attributes.ContainsKey("src"))
            {
                string imagePath = node.Attributes["src"];
                if (!CustomLinqExtensions.CustomIsNullOrEmpty(imagePath))
                {
                    try
                    {
                        string fullImagePath = Path.Combine(htmlFolderPath, imagePath);

                        if (File.Exists(fullImagePath))
                        {
                            Bitmap image = new Bitmap(fullImagePath);
                            pictureBox.Image = image;
                        }
                        else
                        {
                            MessageBox.Show($"Image file does not exist: {fullImagePath}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
            }

            foreach (var child in node.Children)
            {
                DisplayImages(child, htmlFolderPath);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow(root);
            searchWindow.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveWindow saveWindow = new SaveWindow(root);
            saveWindow.Show();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            SetWindow setWindow = new SetWindow(root);
            this.Hide();
            setWindow.Show();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            CopyWindow copyWindow = new CopyWindow(root);
            this.Hide();
            copyWindow.Show();
        }

        private void QuitLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
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
    }
}
