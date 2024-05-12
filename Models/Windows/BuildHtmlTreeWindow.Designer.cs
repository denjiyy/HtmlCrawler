namespace HTML.Models.Windows
{
    partial class BuildHtmlTreeWindow
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
            FilePathTextBox = new TextBox();
            BuildTreeButton = new Button();
            QuitBuildTree = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(777, 37);
            label1.TabIndex = 0;
            label1.Text = "Enter a file location in order to create a tree from an HTML code:";
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Font = new Font("Segoe UI", 16F);
            FilePathTextBox.Location = new Point(11, 49);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.Size = new Size(776, 43);
            FilePathTextBox.TabIndex = 1;
            // 
            // BuildTreeButton
            // 
            BuildTreeButton.Font = new Font("Segoe UI", 16F);
            BuildTreeButton.Location = new Point(297, 98);
            BuildTreeButton.Name = "BuildTreeButton";
            BuildTreeButton.Size = new Size(200, 110);
            BuildTreeButton.TabIndex = 2;
            BuildTreeButton.Text = "Build Tree";
            BuildTreeButton.UseVisualStyleBackColor = true;
            BuildTreeButton.Click += BuildTreeButton_Click;
            // 
            // QuitBuildTree
            // 
            QuitBuildTree.ActiveLinkColor = Color.Black;
            QuitBuildTree.AutoSize = true;
            QuitBuildTree.Font = new Font("Segoe UI", 16F);
            QuitBuildTree.LinkColor = Color.Black;
            QuitBuildTree.Location = new Point(360, 211);
            QuitBuildTree.Name = "QuitBuildTree";
            QuitBuildTree.Size = new Size(68, 37);
            QuitBuildTree.TabIndex = 3;
            QuitBuildTree.TabStop = true;
            QuitBuildTree.Text = "Quit";
            QuitBuildTree.LinkClicked += QuitBuildTree_LinkClicked;
            // 
            // BuildHtmlTreeWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 254);
            Controls.Add(QuitBuildTree);
            Controls.Add(BuildTreeButton);
            Controls.Add(FilePathTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BuildHtmlTreeWindow";
            Text = "Build Tree";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FilePathTextBox;
        private Button BuildTreeButton;
        private LinkLabel QuitBuildTree;
    }
}