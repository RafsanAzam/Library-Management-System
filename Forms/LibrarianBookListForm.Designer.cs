namespace Library_Management_System.Forms
{
    partial class LibrarianBookListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianBookListForm));
            this.BookListLabelLibrarian = new System.Windows.Forms.Label();
            this.bookListViewLibrarian = new System.Windows.Forms.ListView();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.EditBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookListLabelLibrarian
            // 
            this.BookListLabelLibrarian.AutoSize = true;
            this.BookListLabelLibrarian.BackColor = System.Drawing.SystemColors.GrayText;
            this.BookListLabelLibrarian.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListLabelLibrarian.ForeColor = System.Drawing.Color.Transparent;
            this.BookListLabelLibrarian.Location = new System.Drawing.Point(595, 29);
            this.BookListLabelLibrarian.Name = "BookListLabelLibrarian";
            this.BookListLabelLibrarian.Size = new System.Drawing.Size(127, 29);
            this.BookListLabelLibrarian.TabIndex = 0;
            this.BookListLabelLibrarian.Text = "Book List";
            // 
            // bookListViewLibrarian
            // 
            this.bookListViewLibrarian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(210)))));
            this.bookListViewLibrarian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookListViewLibrarian.FullRowSelect = true;
            this.bookListViewLibrarian.HideSelection = false;
            this.bookListViewLibrarian.Location = new System.Drawing.Point(241, 201);
            this.bookListViewLibrarian.MultiSelect = false;
            this.bookListViewLibrarian.Name = "bookListViewLibrarian";
            this.bookListViewLibrarian.Size = new System.Drawing.Size(839, 408);
            this.bookListViewLibrarian.TabIndex = 1;
            this.bookListViewLibrarian.UseCompatibleStateImageBehavior = false;
            this.bookListViewLibrarian.SelectedIndexChanged += new System.EventHandler(this.bookListViewLibrarian_SelectedIndexChanged);
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Goldenrod;
            this.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookButton.ForeColor = System.Drawing.Color.Lavender;
            this.AddBookButton.Location = new System.Drawing.Point(241, 632);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(144, 44);
            this.AddBookButton.TabIndex = 8;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookButton.ForeColor = System.Drawing.Color.Lavender;
            this.DeleteBookButton.Location = new System.Drawing.Point(898, 632);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(182, 44);
            this.DeleteBookButton.TabIndex = 9;
            this.DeleteBookButton.Text = "Delete Book";
            this.DeleteBookButton.UseVisualStyleBackColor = false;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchtextBox.Location = new System.Drawing.Point(452, 129);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(408, 27);
            this.SearchtextBox.TabIndex = 10;
            this.SearchtextBox.Text = "Search Books";
            this.SearchtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchtextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchtextBox_MouseClick);
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // searchBookButton
            // 
            this.searchBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookButton.Location = new System.Drawing.Point(600, 162);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(122, 33);
            this.searchBookButton.TabIndex = 11;
            this.searchBookButton.Text = "Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            // 
            // EditBookButton
            // 
            this.EditBookButton.BackColor = System.Drawing.Color.Green;
            this.EditBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBookButton.ForeColor = System.Drawing.Color.Lavender;
            this.EditBookButton.Location = new System.Drawing.Point(578, 632);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(144, 44);
            this.EditBookButton.TabIndex = 12;
            this.EditBookButton.Text = "Edit Book";
            this.EditBookButton.UseVisualStyleBackColor = false;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click);
            // 
            // LibrarianBookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 819);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.bookListViewLibrarian);
            this.Controls.Add(this.BookListLabelLibrarian);
            this.Name = "LibrarianBookListForm";
            this.Text = "Book List";
            this.Load += new System.EventHandler(this.LibrarianBookListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookListLabelLibrarian;
        private System.Windows.Forms.ListView bookListViewLibrarian;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.Button EditBookButton;
    }
}