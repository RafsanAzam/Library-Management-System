namespace Library_Management_System.Forms
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.bookListViewMember = new System.Windows.Forms.ListView();
            this.BookListLabelLibrarian = new System.Windows.Forms.Label();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookListViewMember
            // 
            this.bookListViewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(210)))));
            this.bookListViewMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookListViewMember.FullRowSelect = true;
            this.bookListViewMember.HideSelection = false;
            this.bookListViewMember.Location = new System.Drawing.Point(212, 203);
            this.bookListViewMember.MultiSelect = false;
            this.bookListViewMember.Name = "bookListViewMember";
            this.bookListViewMember.Size = new System.Drawing.Size(839, 408);
            this.bookListViewMember.TabIndex = 2;
            this.bookListViewMember.UseCompatibleStateImageBehavior = false;
            this.bookListViewMember.SelectedIndexChanged += new System.EventHandler(this.bookListViewLibrarian_SelectedIndexChanged);
            // 
            // BookListLabelLibrarian
            // 
            this.BookListLabelLibrarian.AutoSize = true;
            this.BookListLabelLibrarian.BackColor = System.Drawing.SystemColors.GrayText;
            this.BookListLabelLibrarian.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListLabelLibrarian.ForeColor = System.Drawing.Color.Transparent;
            this.BookListLabelLibrarian.Location = new System.Drawing.Point(528, 23);
            this.BookListLabelLibrarian.Name = "BookListLabelLibrarian";
            this.BookListLabelLibrarian.Size = new System.Drawing.Size(214, 29);
            this.BookListLabelLibrarian.TabIndex = 3;
            this.BookListLabelLibrarian.Text = "Borrowed Books";
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.BackColor = System.Drawing.Color.Goldenrod;
            this.ReturnBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookButton.ForeColor = System.Drawing.Color.Lavender;
            this.ReturnBookButton.Location = new System.Drawing.Point(544, 659);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(167, 44);
            this.ReturnBookButton.TabIndex = 9;
            this.ReturnBookButton.Text = "Return Book";
            this.ReturnBookButton.UseVisualStyleBackColor = false;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchtextBox.Location = new System.Drawing.Point(425, 105);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(408, 27);
            this.SearchtextBox.TabIndex = 11;
            this.SearchtextBox.Text = "Search Books";
            this.SearchtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchBookButton
            // 
            this.searchBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookButton.Location = new System.Drawing.Point(568, 138);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(122, 33);
            this.searchBookButton.TabIndex = 12;
            this.searchBookButton.Text = "Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 824);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.BookListLabelLibrarian);
            this.Controls.Add(this.bookListViewMember);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookListViewMember;
        private System.Windows.Forms.Label BookListLabelLibrarian;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button searchBookButton;
    }
}