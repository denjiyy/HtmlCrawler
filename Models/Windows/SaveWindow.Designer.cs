namespace HTML.Models.Windows
{
    partial class SaveWindow
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
            SaveDocument = new Button();
            BackLabel = new LinkLabel();
            RelativePathTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SaveDocument
            // 
            SaveDocument.Font = new Font("Segoe UI", 16F);
            SaveDocument.Location = new Point(226, 148);
            SaveDocument.Name = "SaveDocument";
            SaveDocument.Size = new Size(278, 116);
            SaveDocument.TabIndex = 7;
            SaveDocument.Text = "Save";
            SaveDocument.UseVisualStyleBackColor = true;
            SaveDocument.Click += SaveDocument_Click;
            // 
            // BackLabel
            // 
            BackLabel.ActiveLinkColor = Color.Black;
            BackLabel.AutoSize = true;
            BackLabel.Font = new Font("Segoe UI", 16F);
            BackLabel.LinkColor = Color.Black;
            BackLabel.Location = new Point(333, 267);
            BackLabel.Name = "BackLabel";
            BackLabel.Size = new Size(71, 37);
            BackLabel.TabIndex = 6;
            BackLabel.TabStop = true;
            BackLabel.Text = "Back";
            BackLabel.LinkClicked += BackLabel_LinkClicked;
            // 
            // RelativePathTextBox
            // 
            RelativePathTextBox.Font = new Font("Segoe UI", 16F);
            RelativePathTextBox.Location = new Point(12, 88);
            RelativePathTextBox.Name = "RelativePathTextBox";
            RelativePathTextBox.Size = new Size(699, 43);
            RelativePathTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(66, 48);
            label1.Name = "label1";
            label1.Size = new Size(609, 37);
            label1.TabIndex = 4;
            label1.Text = "Where do you want the document to be saved to?";
            // 
            // SaveWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 312);
            Controls.Add(SaveDocument);
            Controls.Add(BackLabel);
            Controls.Add(RelativePathTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SaveWindow";
            Text = "Save Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveDocument;
        private LinkLabel BackLabel;
        private TextBox RelativePathTextBox;
        private Label label1;
    }
}