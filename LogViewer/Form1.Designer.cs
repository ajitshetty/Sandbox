namespace LogViewer
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.LogFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Button();
            this.LogInfoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(524, 24);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(100, 25);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // LogFolder
            // 
            this.LogFolder.Location = new System.Drawing.Point(68, 26);
            this.LogFolder.Name = "LogFolder";
            this.LogFolder.Size = new System.Drawing.Size(430, 20);
            this.LogFolder.TabIndex = 1;
            this.LogFolder.Text = "D:\\ChartImages\\TCC\\TCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder";
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(656, 24);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(114, 25);
            this.Process.TabIndex = 3;
            this.Process.Text = "Start Processing";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // LogInfoBox
            // 
            this.LogInfoBox.Location = new System.Drawing.Point(28, 78);
            this.LogInfoBox.Multiline = true;
            this.LogInfoBox.Name = "LogInfoBox";
            this.LogInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogInfoBox.Size = new System.Drawing.Size(759, 351);
            this.LogInfoBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 472);
            this.Controls.Add(this.LogInfoBox);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogFolder);
            this.Controls.Add(this.BrowseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox LogFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.TextBox LogInfoBox;
    }
}

