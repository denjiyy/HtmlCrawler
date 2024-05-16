namespace HTML
{
    partial class SetWindow
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
            BackLabel = new LinkLabel();
            RelativePath = new TextBox();
            label1 = new Label();
            SetRelativePath = new Button();
            NewContent = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // BackLabel
            // 
            BackLabel.ActiveLinkColor = Color.Black;
            BackLabel.AutoSize = true;
            BackLabel.Font = new Font("Segoe UI", 16F);
            BackLabel.LinkColor = Color.Black;
            BackLabel.Location = new Point(334, 407);
            BackLabel.Name = "BackLabel";
            BackLabel.Size = new Size(71, 37);
            BackLabel.TabIndex = 5;
            BackLabel.TabStop = true;
            BackLabel.Text = "Back";
            BackLabel.LinkClicked += BackLabel_LinkClicked;
            // 
            // RelativePath
            // 
            RelativePath.Font = new Font("Segoe UI", 16F);
            RelativePath.Location = new Point(12, 87);
            RelativePath.Name = "RelativePath";
            RelativePath.Size = new Size(699, 43);
            RelativePath.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(145, 47);
            label1.Name = "label1";
            label1.Size = new Size(451, 37);
            label1.TabIndex = 3;
            label1.Text = "Enter relative path (start with //root):";
            // 
            // SetRelativePath
            // 
            SetRelativePath.Font = new Font("Segoe UI", 16F);
            SetRelativePath.Location = new Point(227, 275);
            SetRelativePath.Name = "SetRelativePath";
            SetRelativePath.Size = new Size(278, 116);
            SetRelativePath.TabIndex = 6;
            SetRelativePath.Text = "Set";
            SetRelativePath.UseVisualStyleBackColor = false;
            SetRelativePath.Click += SetRelativePath_Click;
            // 
            // NewContent
            // 
            NewContent.Font = new Font("Segoe UI", 16F);
            NewContent.Location = new Point(12, 205);
            NewContent.Name = "NewContent";
            NewContent.Size = new Size(699, 43);
            NewContent.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(223, 165);
            label2.Name = "label2";
            label2.Size = new Size(282, 37);
            label2.TabIndex = 8;
            label2.Text = "Enter the new content:";
            // 
            // SetWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 453);
            Controls.Add(label2);
            Controls.Add(NewContent);
            Controls.Add(SetRelativePath);
            Controls.Add(BackLabel);
            Controls.Add(RelativePath);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SetWindow";
            Text = "Set Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel BackLabel;
        private TextBox RelativePath;
        private Label label1;
        private Button SetRelativePath;
        private TextBox NewContent;
        private Label label2;
    }
}