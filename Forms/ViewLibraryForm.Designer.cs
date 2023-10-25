namespace Library_Management_System.Forms
{
    partial class ViewLibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLibraryForm));
            this.BookListLabelLibrarian = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.bookListViewLibrarian = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BookListLabelLibrarian
            // 
            this.BookListLabelLibrarian.AutoSize = true;
            this.BookListLabelLibrarian.BackColor = System.Drawing.SystemColors.GrayText;
            this.BookListLabelLibrarian.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListLabelLibrarian.ForeColor = System.Drawing.Color.Transparent;
            this.BookListLabelLibrarian.Location = new System.Drawing.Point(548, 27);
            this.BookListLabelLibrarian.Name = "BookListLabelLibrarian";
            this.BookListLabelLibrarian.Size = new System.Drawing.Size(127, 29);
            this.BookListLabelLibrarian.TabIndex = 1;
            this.BookListLabelLibrarian.Text = "Book List";
            this.BookListLabelLibrarian.Click += new System.EventHandler(this.BookListLabelLibrarian_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchtextBox.Location = new System.Drawing.Point(407, 112);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(408, 27);
            this.SearchtextBox.TabIndex = 11;
            this.SearchtextBox.Text = "Search Books";
            this.SearchtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchtextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchtextBox_MouseClick);
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // searchBookButton
            // 
            this.searchBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookButton.Location = new System.Drawing.Point(553, 145);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(122, 33);
            this.searchBookButton.TabIndex = 12;
            this.searchBookButton.Text = "Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            // 
            // bookListViewLibrarian
            // 
            this.bookListViewLibrarian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(210)))));
            this.bookListViewLibrarian.FullRowSelect = true;
            this.bookListViewLibrarian.HideSelection = false;
            this.bookListViewLibrarian.Location = new System.Drawing.Point(214, 210);
            this.bookListViewLibrarian.MultiSelect = false;
            this.bookListViewLibrarian.Name = "bookListViewLibrarian";
            this.bookListViewLibrarian.Size = new System.Drawing.Size(828, 408);
            this.bookListViewLibrarian.TabIndex = 13;
            this.bookListViewLibrarian.UseCompatibleStateImageBehavior = false;
            this.bookListViewLibrarian.SelectedIndexChanged += new System.EventHandler(this.bookListViewLibrarian_SelectedIndexChanged);
            // 
            // ViewLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1243, 790);
            this.Controls.Add(this.bookListViewLibrarian);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.BookListLabelLibrarian);
            this.Name = "ViewLibraryForm";
            this.Text = "Library ";
            this.Load += new System.EventHandler(this.ViewLibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookListLabelLibrarian;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.ListView bookListViewLibrarian;
    }
}