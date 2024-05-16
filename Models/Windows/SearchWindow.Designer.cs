namespace HTML
{
    partial class SearchWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            RelativePathTextBox = new TextBox();
            BackLabel = new LinkLabel();
            SearchRelativePath = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(145, 47);
            label1.Name = "label1";
            label1.Size = new Size(451, 37);
            label1.TabIndex = 0;
            label1.Text = "Enter relative path (start with //root):";
            // 
            // RelativePathTextBox
            // 
            RelativePathTextBox.Font = new Font("Segoe UI", 16F);
            RelativePathTextBox.Location = new Point(12, 87);
            RelativePathTextBox.Name = "RelativePathTextBox";
            RelativePathTextBox.Size = new Size(699, 43);
            RelativePathTextBox.TabIndex = 1;
            // 
            // BackLabel
            // 
            BackLabel.ActiveLinkColor = Color.Black;
            BackLabel.AutoSize = true;
            BackLabel.Font = new Font("Segoe UI", 16F);
            BackLabel.LinkColor = Color.Black;
            BackLabel.Location = new Point(333, 266);
            BackLabel.Name = "BackLabel";
            BackLabel.Size = new Size(71, 37);
            BackLabel.TabIndex = 2;
            BackLabel.TabStop = true;
            BackLabel.Text = "Back";
            BackLabel.LinkClicked += BackLabel_LinkClicked;
            // 
            // SearchRelativePath
            // 
            SearchRelativePath.Font = new Font("Segoe UI", 16F);
            SearchRelativePath.Location = new Point(226, 147);
            SearchRelativePath.Name = "SearchRelativePath";
            SearchRelativePath.Size = new Size(278, 116);
            SearchRelativePath.TabIndex = 3;
            SearchRelativePath.Text = "Search";
            SearchRelativePath.UseVisualStyleBackColor = true;
            SearchRelativePath.Click += SearchRelativePath_Click;
            // 
            // SearchWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 312);
            Controls.Add(SearchRelativePath);
            Controls.Add(BackLabel);
            Controls.Add(RelativePathTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SearchWindow";
            Text = "Search Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RelativePathTextBox;
        private LinkLabel BackLabel;
        private Button SearchRelativePath;
    }
}