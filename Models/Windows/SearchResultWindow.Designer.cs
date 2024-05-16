namespace HTML.Models.Windows
{
    partial class SearchResultWindow
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
            ResultsListBox = new ListBox();
            OK = new Button();
            SuspendLayout();
            // 
            // ResultsListBox
            // 
            ResultsListBox.FormattingEnabled = true;
            ResultsListBox.Location = new Point(12, 12);
            ResultsListBox.Name = "ResultsListBox";
            ResultsListBox.Size = new Size(496, 344);
            ResultsListBox.TabIndex = 0;
            // 
            // OK
            // 
            OK.Font = new Font("Segoe UI", 16F);
            OK.Location = new Point(145, 375);
            OK.Name = "OK";
            OK.Size = new Size(237, 63);
            OK.TabIndex = 1;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // SearchResultWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 450);
            Controls.Add(OK);
            Controls.Add(ResultsListBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SearchResultWindow";
            Text = "Search Results";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ResultsListBox;
        private Button OK;
    }
}