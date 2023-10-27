namespace Library_Management_System.Forms
{
    partial class BorrowBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBookForm));
            this.BookListLabelLibrarian = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.bookListViewMember = new System.Windows.Forms.ListView();
            this.BorrowBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookListLabelLibrarian
            // 
            this.BookListLabelLibrarian.AutoSize = true;
            this.BookListLabelLibrarian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BookListLabelLibrarian.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListLabelLibrarian.ForeColor = System.Drawing.Color.Transparent;
            this.BookListLabelLibrarian.Location = new System.Drawing.Point(593, 45);
            this.BookListLabelLibrarian.Name = "BookListLabelLibrarian";
            this.BookListLabelLibrarian.Size = new System.Drawing.Size(127, 29);
            this.BookListLabelLibrarian.TabIndex = 1;
            this.BookListLabelLibrarian.Text = "Book List";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchtextBox.Location = new System.Drawing.Point(454, 115);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(408, 27);
            this.SearchtextBox.TabIndex = 11;
            this.SearchtextBox.Text = "Search Books";
            this.SearchtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchtextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchtextBox_MouseClick);
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // bookListViewMember
            // 
            this.bookListViewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(172)))), ((int)(((byte)(133)))));
            this.bookListViewMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookListViewMember.FullRowSelect = true;
            this.bookListViewMember.HideSelection = false;
            this.bookListViewMember.Location = new System.Drawing.Point(228, 157);
            this.bookListViewMember.MultiSelect = false;
            this.bookListViewMember.Name = "bookListViewMember";
            this.bookListViewMember.Size = new System.Drawing.Size(839, 441);
            this.bookListViewMember.TabIndex = 12;
            this.bookListViewMember.UseCompatibleStateImageBehavior = false;
            this.bookListViewMember.SelectedIndexChanged += new System.EventHandler(this.bookListViewLibrarian_SelectedIndexChanged);
            // 
            // BorrowBookButton
            // 
            this.BorrowBookButton.BackColor = System.Drawing.Color.SandyBrown;
            this.BorrowBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BorrowBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBookButton.ForeColor = System.Drawing.Color.Lavender;
            this.BorrowBookButton.Location = new System.Drawing.Point(566, 629);
            this.BorrowBookButton.Name = "BorrowBookButton";
            this.BorrowBookButton.Size = new System.Drawing.Size(184, 44);
            this.BorrowBookButton.TabIndex = 13;
            this.BorrowBookButton.Text = "Borrow Book";
            this.BorrowBookButton.UseVisualStyleBackColor = false;
            this.BorrowBookButton.Click += new System.EventHandler(this.BorrowBookButton_Click);
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1329, 697);
            this.Controls.Add(this.BorrowBookButton);
            this.Controls.Add(this.bookListViewMember);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.BookListLabelLibrarian);
            this.Name = "BorrowBookForm";
            this.Text = "Borrow Book Form";
            this.Load += new System.EventHandler(this.BorrowBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookListLabelLibrarian;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.ListView bookListViewMember;
        private System.Windows.Forms.Button BorrowBookButton;
    }
}