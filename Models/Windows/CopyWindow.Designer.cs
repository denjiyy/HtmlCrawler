namespace HTML
{
    partial class CopyWindow
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
            label2 = new Label();
            TargetPath = new TextBox();
            CopyButton = new Button();
            BackLabel = new LinkLabel();
            RelativePath = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(223, 164);
            label2.Name = "label2";
            label2.Size = new Size(362, 37);
            label2.TabIndex = 14;
            label2.Text = "Enter the target relative path:";
            // 
            // TargetPath
            // 
            TargetPath.Font = new Font("Segoe UI", 16F);
            TargetPath.Location = new Point(12, 204);
            TargetPath.Name = "TargetPath";
            TargetPath.Size = new Size(699, 43);
            TargetPath.TabIndex = 13;
            // 
            // CopyButton
            // 
            CopyButton.Font = new Font("Segoe UI", 16F);
            CopyButton.Location = new Point(227, 274);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(278, 116);
            CopyButton.TabIndex = 12;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = false;
            CopyButton.Click += CopyButton_Click;
            // 
            // BackLabel
            // 
            BackLabel.ActiveLinkColor = Color.Black;
            BackLabel.AutoSize = true;
            BackLabel.Font = new Font("Segoe UI", 16F);
            BackLabel.LinkColor = Color.Black;
            BackLabel.Location = new Point(334, 406);
            BackLabel.Name = "BackLabel";
            BackLabel.Size = new Size(71, 37);
            BackLabel.TabIndex = 11;
            BackLabel.TabStop = true;
            BackLabel.Text = "Back";
            BackLabel.LinkClicked += BackLabel_LinkClicked_1;
            // 
            // RelativePath
            // 
            RelativePath.Font = new Font("Segoe UI", 16F);
            RelativePath.Location = new Point(12, 86);
            RelativePath.Name = "RelativePath";
            RelativePath.Size = new Size(699, 43);
            RelativePath.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(74, 46);
            label1.Name = "label1";
            label1.Size = new Size(580, 37);
            label1.TabIndex = 9;
            label1.Text = "Enter the source relative path (start with //root):";
            // 
            // CopyWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 453);
            Controls.Add(label2);
            Controls.Add(TargetPath);
            Controls.Add(CopyButton);
            Controls.Add(BackLabel);
            Controls.Add(RelativePath);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CopyWindow";
            Text = "Copy Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox TargetPath;
        private Button CopyButton;
        private LinkLabel BackLabel;
        private TextBox RelativePath;
        private Label label1;
    }
}