namespace Library_Management_System.Forms
{
    partial class MemberDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboardForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ViewLibraryButton = new System.Windows.Forms.Button();
            this.BorrowBookButton = new System.Windows.Forms.Button();
            this.ViewProfileButton = new System.Windows.Forms.Button();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to The Member Dashboard!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewLibraryButton
            // 
            this.ViewLibraryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLibraryButton.Location = new System.Drawing.Point(143, 215);
            this.ViewLibraryButton.Name = "ViewLibraryButton";
            this.ViewLibraryButton.Size = new System.Drawing.Size(192, 36);
            this.ViewLibraryButton.TabIndex = 7;
            this.ViewLibraryButton.Text = "View Library";
            this.ViewLibraryButton.UseVisualStyleBackColor = true;
            this.ViewLibraryButton.Click += new System.EventHandler(this.ViewLibraryButton_Click);
            // 
            // BorrowBookButton
            // 
            this.BorrowBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBookButton.Location = new System.Drawing.Point(143, 286);
            this.BorrowBookButton.Name = "BorrowBookButton";
            this.BorrowBookButton.Size = new System.Drawing.Size(192, 36);
            this.BorrowBookButton.TabIndex = 8;
            this.BorrowBookButton.Text = "Borrow Book";
            this.BorrowBookButton.UseVisualStyleBackColor = true;
            this.BorrowBookButton.Click += new System.EventHandler(this.BorrowBookButton_Click);
            // 
            // ViewProfileButton
            // 
            this.ViewProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProfileButton.Location = new System.Drawing.Point(143, 350);
            this.ViewProfileButton.Name = "ViewProfileButton";
            this.ViewProfileButton.Size = new System.Drawing.Size(192, 36);
            this.ViewProfileButton.TabIndex = 9;
            this.ViewProfileButton.Text = "View Profile";
            this.ViewProfileButton.UseVisualStyleBackColor = true;
            this.ViewProfileButton.Click += new System.EventHandler(this.ViewProfileButton_Click);
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookButton.Location = new System.Drawing.Point(143, 417);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(192, 36);
            this.ReturnBookButton.TabIndex = 10;
            this.ReturnBookButton.Text = "Return Book";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(143, 479);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(192, 36);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // MemberDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 654);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.ViewProfileButton);
            this.Controls.Add(this.BorrowBookButton);
            this.Controls.Add(this.ViewLibraryButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberDashboardForm";
            this.Text = "Member Dashboard";
            this.Load += new System.EventHandler(this.MemberDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewLibraryButton;
        private System.Windows.Forms.Button BorrowBookButton;
        private System.Windows.Forms.Button ViewProfileButton;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.Button logOutButton;
    }
}