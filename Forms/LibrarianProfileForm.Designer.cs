namespace Library_Management_System.Forms
{
    partial class LibrarianProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianProfileForm));
            this.LibrarianProfileLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.librarianIdlabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.NameOutputLabel = new System.Windows.Forms.Label();
            this.IdOutputLabel = new System.Windows.Forms.Label();
            this.userNameOutputLabel = new System.Windows.Forms.Label();
            this.EmailOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LibrarianProfileLabel
            // 
            this.LibrarianProfileLabel.AutoSize = true;
            this.LibrarianProfileLabel.BackColor = System.Drawing.Color.Bisque;
            this.LibrarianProfileLabel.Location = new System.Drawing.Point(308, 68);
            this.LibrarianProfileLabel.Name = "LibrarianProfileLabel";
            this.LibrarianProfileLabel.Size = new System.Drawing.Size(269, 40);
            this.LibrarianProfileLabel.TabIndex = 1;
            this.LibrarianProfileLabel.Text = "Librarian Profile";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.BackColor = System.Drawing.Color.Bisque;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(106, 175);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(70, 25);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name:";
            // 
            // librarianIdlabel
            // 
            this.librarianIdlabel.AutoSize = true;
            this.librarianIdlabel.BackColor = System.Drawing.Color.Bisque;
            this.librarianIdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarianIdlabel.Location = new System.Drawing.Point(106, 215);
            this.librarianIdlabel.Name = "librarianIdlabel";
            this.librarianIdlabel.Size = new System.Drawing.Size(42, 25);
            this.librarianIdlabel.TabIndex = 3;
            this.librarianIdlabel.Text = " ID:";
            this.librarianIdlabel.Click += new System.EventHandler(this.memberIdlabel_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Bisque;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(106, 250);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(108, 25);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Username:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Bisque;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(106, 297);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 25);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email:";
            // 
            // NameOutputLabel
            // 
            this.NameOutputLabel.AutoSize = true;
            this.NameOutputLabel.BackColor = System.Drawing.Color.Bisque;
            this.NameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameOutputLabel.Location = new System.Drawing.Point(235, 175);
            this.NameOutputLabel.Name = "NameOutputLabel";
            this.NameOutputLabel.Size = new System.Drawing.Size(76, 25);
            this.NameOutputLabel.TabIndex = 8;
            this.NameOutputLabel.Text = "[Name]";
            // 
            // IdOutputLabel
            // 
            this.IdOutputLabel.AutoSize = true;
            this.IdOutputLabel.BackColor = System.Drawing.Color.Bisque;
            this.IdOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOutputLabel.Location = new System.Drawing.Point(235, 215);
            this.IdOutputLabel.Name = "IdOutputLabel";
            this.IdOutputLabel.Size = new System.Drawing.Size(43, 25);
            this.IdOutputLabel.TabIndex = 9;
            this.IdOutputLabel.Text = "[ID]";
            // 
            // userNameOutputLabel
            // 
            this.userNameOutputLabel.AutoSize = true;
            this.userNameOutputLabel.BackColor = System.Drawing.Color.Bisque;
            this.userNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameOutputLabel.Location = new System.Drawing.Point(235, 250);
            this.userNameOutputLabel.Name = "userNameOutputLabel";
            this.userNameOutputLabel.Size = new System.Drawing.Size(114, 25);
            this.userNameOutputLabel.TabIndex = 10;
            this.userNameOutputLabel.Text = "[Username]";
            // 
            // EmailOutputLabel
            // 
            this.EmailOutputLabel.AutoSize = true;
            this.EmailOutputLabel.BackColor = System.Drawing.Color.Bisque;
            this.EmailOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailOutputLabel.Location = new System.Drawing.Point(235, 297);
            this.EmailOutputLabel.Name = "EmailOutputLabel";
            this.EmailOutputLabel.Size = new System.Drawing.Size(72, 25);
            this.EmailOutputLabel.TabIndex = 11;
            this.EmailOutputLabel.Text = "[Email]";
            // 
            // LibrarianProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(813, 721);
            this.Controls.Add(this.EmailOutputLabel);
            this.Controls.Add(this.userNameOutputLabel);
            this.Controls.Add(this.IdOutputLabel);
            this.Controls.Add(this.NameOutputLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.librarianIdlabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.LibrarianProfileLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LibrarianProfileForm";
            this.Text = "Librarian Profile";
            this.Load += new System.EventHandler(this.LibrarianProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LibrarianProfileLabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label librarianIdlabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label NameOutputLabel;
        private System.Windows.Forms.Label IdOutputLabel;
        private System.Windows.Forms.Label userNameOutputLabel;
        private System.Windows.Forms.Label EmailOutputLabel;
    }
}