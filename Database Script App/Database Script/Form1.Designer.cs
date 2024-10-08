namespace Database_Script
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            txtFilePath = new TextBox();
            btnSelectFolder = new Button();
            btnCreateScript = new Button();
            label1 = new Label();
            txtMergedFile = new TextBox();
            label2 = new Label();
            btnSaveFile = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(28, 49);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(454, 23);
            txtFilePath.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(490, 49);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(38, 23);
            btnSelectFolder.TabIndex = 1;
            btnSelectFolder.Text = "...";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // btnCreateScript
            // 
            btnCreateScript.Location = new Point(453, 119);
            btnCreateScript.Name = "btnCreateScript";
            btnCreateScript.Size = new Size(75, 23);
            btnCreateScript.TabIndex = 2;
            btnCreateScript.Text = "Create";
            btnCreateScript.UseVisualStyleBackColor = true;
            btnCreateScript.Click += btnCreateScript_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "Root Folder";
            // 
            // txtMergedFile
            // 
            txtMergedFile.Location = new Point(29, 148);
            txtMergedFile.Multiline = true;
            txtMergedFile.Name = "txtMergedFile";
            txtMergedFile.ScrollBars = ScrollBars.Both;
            txtMergedFile.Size = new Size(499, 246);
            txtMergedFile.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 127);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Merged Contents";
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(453, 415);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(75, 23);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "Save";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 465);
            Controls.Add(btnSaveFile);
            Controls.Add(label2);
            Controls.Add(txtMergedFile);
            Controls.Add(label1);
            Controls.Add(btnCreateScript);
            Controls.Add(btnSelectFolder);
            Controls.Add(txtFilePath);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Database Script App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox txtFilePath;
        private Button btnSelectFolder;
        private Button btnCreateScript;
        private Label label1;
        private TextBox txtMergedFile;
        private Label label2;
        private Button btnSaveFile;
    }
}
