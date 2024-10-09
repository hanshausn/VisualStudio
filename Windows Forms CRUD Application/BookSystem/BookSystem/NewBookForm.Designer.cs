namespace BookSystem
{
    partial class NewBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBookForm));
            btnOK = new Button();
            btnCancel = new Button();
            txtTitle = new TextBox();
            lblTitle = new Label();
            txtIsbn = new TextBox();
            lblIsbn = new Label();
            txtPublisher = new TextBox();
            btnPublisher = new Label();
            txtAuthor = new TextBox();
            lblAuthor = new Label();
            txtCategory = new TextBox();
            lblCategory = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(234, 351);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(326, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(35, 61);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(366, 23);
            txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(35, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title:";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(35, 116);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(366, 23);
            txtIsbn.TabIndex = 2;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(35, 97);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(35, 15);
            lblIsbn.TabIndex = 2;
            lblIsbn.Text = "ISBN:";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(35, 175);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(366, 23);
            txtPublisher.TabIndex = 3;
            // 
            // btnPublisher
            // 
            btnPublisher.AutoSize = true;
            btnPublisher.Location = new Point(35, 156);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(59, 15);
            btnPublisher.TabIndex = 2;
            btnPublisher.Text = "Publisher:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(35, 232);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(366, 23);
            txtAuthor.TabIndex = 4;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(35, 213);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(35, 287);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(366, 23);
            txtCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(35, 268);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // NewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(437, 404);
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
            Name = "NewBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtIsbn;
        private Label lblIsbn;
        private TextBox txtPublisher;
        private Label btnPublisher;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private TextBox txtCategory;
        private Label lblCategory;
    }
}