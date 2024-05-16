namespace HTML
{
    partial class HtmlCrawlerWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SearchButton = new Button();
            SetButton = new Button();
            CopyButton = new Button();
            SaveButton = new Button();
            panel1 = new Panel();
            QuitLabel = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchButton.Location = new Point(59, 29);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(211, 95);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SetButton
            // 
            SetButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SetButton.Location = new Point(59, 231);
            SetButton.Name = "SetButton";
            SetButton.Size = new Size(211, 95);
            SetButton.TabIndex = 1;
            SetButton.Text = "Set";
            SetButton.UseVisualStyleBackColor = true;
            SetButton.Click += SetButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CopyButton.Location = new Point(59, 436);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(211, 95);
            CopyButton.TabIndex = 2;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(59, 646);
            SaveButton.Name = "SaveButton";
            SaveButton.RightToLeft = RightToLeft.No;
            SaveButton.Size = new Size(211, 95);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(SetButton);
            panel1.Controls.Add(CopyButton);
            panel1.Location = new Point(1109, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 797);
            panel1.TabIndex = 4;
            // 
            // QuitLabel
            // 
            QuitLabel.ActiveLinkColor = Color.Black;
            QuitLabel.AutoSize = true;
            QuitLabel.Font = new Font("Segoe UI", 16F);
            QuitLabel.LinkColor = Color.Black;
            QuitLabel.Location = new Point(12, 749);
            QuitLabel.Name = "QuitLabel";
            QuitLabel.Size = new Size(68, 37);
            QuitLabel.TabIndex = 4;
            QuitLabel.TabStop = true;
            QuitLabel.Text = "Quit";
            QuitLabel.LinkClicked += QuitLabel_LinkClicked;
            // 
            // HtmlCrawlerWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1438, 795);
            Controls.Add(QuitLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HtmlCrawlerWindow";
            Text = "HTML Crawler";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private Button SetButton;
        private Button CopyButton;
        private Button SaveButton;
        private Panel panel1;
        private LinkLabel QuitLabel;
    }
}
