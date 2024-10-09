namespace BookSystem
{
    partial class EditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookForm));
            lblCategory = new Label();
            lblAuthor = new Label();
            btnPublisher = new Label();
            lblIsbn = new Label();
            lblTitle = new Label();
            txtCategory = new TextBox();
            txtAuthor = new TextBox();
            txtPublisher = new TextBox();
            txtIsbn = new TextBox();
            txtTitle = new TextBox();
            btnCancel = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(37, 261);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(37, 206);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author:";
            // 
            // btnPublisher
            // 
            btnPublisher.AutoSize = true;
            btnPublisher.Location = new Point(37, 149);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(59, 15);
            btnPublisher.TabIndex = 12;
            btnPublisher.Text = "Publisher:";
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(37, 90);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(35, 15);
            lblIsbn.TabIndex = 13;
            lblIsbn.Text = "ISBN:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(37, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Title:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(37, 280);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(366, 23);
            txtCategory.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(37, 225);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(366, 23);
            txtAuthor.TabIndex = 4;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(37, 168);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(366, 23);
            txtPublisher.TabIndex = 3;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(37, 109);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(366, 23);
            txtIsbn.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(37, 54);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(366, 23);
            txtTitle.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(328, 344);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(236, 344);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(443, 400);
            Controls.Add(lblCategory);
            Controls.Add(lblAuthor);
            Controls.Add(btnPublisher);
            Controls.Add(lblIsbn);
            Controls.Add(lblTitle);
            Controls.Add(txtCategory);
            Controls.Add(txtAuthor);
            Controls.Add(txtPublisher);
            Controls.Add(txtIsbn);
            Controls.Add(txtTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblAuthor;
        private Label btnPublisher;
        private Label lblIsbn;
        private Label lblTitle;
        private TextBox txtCategory;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private TextBox txtIsbn;
        private TextBox txtTitle;
        private Button btnCancel;
        private Button btnOK;
    }
}