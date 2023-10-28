namespace Library_Management_System.Forms
{
    partial class LibrarianDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianDashboardForm));
            this.librarianDashboardLebel = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.updateBooksBtn = new System.Windows.Forms.Button();
            this.ViewProfileBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ViewLibraryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // librarianDashboardLebel
            // 
            this.librarianDashboardLebel.AutoSize = true;
            this.librarianDashboardLebel.BackColor = System.Drawing.Color.Moccasin;
            this.librarianDashboardLebel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.librarianDashboardLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarianDashboardLebel.ForeColor = System.Drawing.Color.DimGray;
            this.librarianDashboardLebel.Location = new System.Drawing.Point(147, 69);
            this.librarianDashboardLebel.Name = "librarianDashboardLebel";
            this.librarianDashboardLebel.Size = new System.Drawing.Size(312, 38);
            this.librarianDashboardLebel.TabIndex = 0;
            this.librarianDashboardLebel.Text = "Librarian Dashboard";
            this.librarianDashboardLebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchtextBox.Location = new System.Drawing.Point(171, 130);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(255, 34);
            this.SearchtextBox.TabIndex = 1;
            this.SearchtextBox.Text = "Search Books";
            this.SearchtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // searchBookButton
            // 
            this.searchBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookButton.Location = new System.Drawing.Point(231, 170);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(122, 40);
            this.searchBookButton.TabIndex = 2;
            this.searchBookButton.Text = "Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateBooksBtn
            // 
            this.updateBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBooksBtn.Location = new System.Drawing.Point(190, 319);
            this.updateBooksBtn.Name = "updateBooksBtn";
            this.updateBooksBtn.Size = new System.Drawing.Size(192, 36);
            this.updateBooksBtn.TabIndex = 3;
            this.updateBooksBtn.Text = "Update Library";
            this.updateBooksBtn.UseVisualStyleBackColor = true;
            this.updateBooksBtn.Click += new System.EventHandler(this.updateBooksBtn_Click);
            // 
            // ViewProfileBtn
            // 
            this.ViewProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProfileBtn.Location = new System.Drawing.Point(190, 381);
            this.ViewProfileBtn.Name = "ViewProfileBtn";
            this.ViewProfileBtn.Size = new System.Drawing.Size(192, 36);
            this.ViewProfileBtn.TabIndex = 4;
            this.ViewProfileBtn.Text = "View Profile";
            this.ViewProfileBtn.UseVisualStyleBackColor = true;
            this.ViewProfileBtn.Click += new System.EventHandler(this.UpdateProfileBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.Location = new System.Drawing.Point(190, 437);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(192, 36);
            this.LogOutBtn.TabIndex = 5;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            // 
            // ViewLibraryButton
            // 
            this.ViewLibraryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLibraryButton.Location = new System.Drawing.Point(190, 261);
            this.ViewLibraryButton.Name = "ViewLibraryButton";
            this.ViewLibraryButton.Size = new System.Drawing.Size(192, 36);
            this.ViewLibraryButton.TabIndex = 6;
            this.ViewLibraryButton.Text = "View Library";
            this.ViewLibraryButton.UseVisualStyleBackColor = true;
            this.ViewLibraryButton.Click += new System.EventHandler(this.ViewLibraryButton_Click);
            // 
            // LibrarianDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(654, 704);
            this.Controls.Add(this.ViewLibraryButton);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ViewProfileBtn);
            this.Controls.Add(this.updateBooksBtn);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.librarianDashboardLebel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LibrarianDashboardForm";
            this.Text = "Librarian Dashboard";
            this.Load += new System.EventHandler(this.LibrarianDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label librarianDashboardLebel;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.Button updateBooksBtn;
        private System.Windows.Forms.Button ViewProfileBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button ViewLibraryButton;
    }
}