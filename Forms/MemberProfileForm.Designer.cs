namespace Library_Management_System.Forms
{
    partial class MemberProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberProfileForm));
            this.memberProfileLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.memberIdlabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BorrowedBooksLabel = new System.Windows.Forms.Label();
            this.BorrowedBooksListView = new System.Windows.Forms.ListView();
            this.NameOutputLabel = new System.Windows.Forms.Label();
            this.IdOutputLabel = new System.Windows.Forms.Label();
            this.userNameOutputLabel = new System.Windows.Forms.Label();
            this.EmailOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberProfileLabel
            // 
            this.memberProfileLabel.AutoSize = true;
            this.memberProfileLabel.Location = new System.Drawing.Point(374, 35);
            this.memberProfileLabel.Name = "memberProfileLabel";
            this.memberProfileLabel.Size = new System.Drawing.Size(206, 32);
            this.memberProfileLabel.TabIndex = 0;
            this.memberProfileLabel.Text = "Member Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // memberIdlabel
            // 
            this.memberIdlabel.AutoSize = true;
            this.memberIdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIdlabel.Location = new System.Drawing.Point(75, 172);
            this.memberIdlabel.Name = "memberIdlabel";
            this.memberIdlabel.Size = new System.Drawing.Size(42, 25);
            this.memberIdlabel.TabIndex = 2;
            this.memberIdlabel.Text = " ID:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(75, 208);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(108, 25);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // BorrowedBooksLabel
            // 
            this.BorrowedBooksLabel.AutoSize = true;
            this.BorrowedBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowedBooksLabel.Location = new System.Drawing.Point(375, 316);
            this.BorrowedBooksLabel.Name = "BorrowedBooksLabel";
            this.BorrowedBooksLabel.Size = new System.Drawing.Size(193, 29);
            this.BorrowedBooksLabel.TabIndex = 5;
            this.BorrowedBooksLabel.Text = "Borrowed Books";
            this.BorrowedBooksLabel.Click += new System.EventHandler(this.BorrowedBooksLabel_Click);
            // 
            // BorrowedBooksListView
            // 
            this.BorrowedBooksListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(210)))));
            this.BorrowedBooksListView.HideSelection = false;
            this.BorrowedBooksListView.Location = new System.Drawing.Point(156, 363);
            this.BorrowedBooksListView.Name = "BorrowedBooksListView";
            this.BorrowedBooksListView.Size = new System.Drawing.Size(633, 307);
            this.BorrowedBooksListView.TabIndex = 6;
            this.BorrowedBooksListView.UseCompatibleStateImageBehavior = false;
            this.BorrowedBooksListView.SelectedIndexChanged += new System.EventHandler(this.BorrowedBooksListView_SelectedIndexChanged);
            // 
            // NameOutputLabel
            // 
            this.NameOutputLabel.AutoSize = true;
            this.NameOutputLabel.BackColor = System.Drawing.Color.Bisque;
            this.NameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameOutputLabel.Location = new System.Drawing.Point(193, 131);
            this.NameOutputLabel.Name = "NameOutputLabel";
            this.NameOutputLabel.Size = new System.Drawing.Size(76, 25);
            this.NameOutputLabel.TabIndex = 7;
            this.NameOutputLabel.Text = "[Name]";
            // 
            // IdOutputLabel
            // 
            this.IdOutputLabel.AutoSize = true;
            this.IdOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOutputLabel.Location = new System.Drawing.Point(193, 172);
            this.IdOutputLabel.Name = "IdOutputLabel";
            this.IdOutputLabel.Size = new System.Drawing.Size(43, 25);
            this.IdOutputLabel.TabIndex = 8;
            this.IdOutputLabel.Text = "[ID]";
            // 
            // userNameOutputLabel
            // 
            this.userNameOutputLabel.AutoSize = true;
            this.userNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameOutputLabel.Location = new System.Drawing.Point(193, 208);
            this.userNameOutputLabel.Name = "userNameOutputLabel";
            this.userNameOutputLabel.Size = new System.Drawing.Size(114, 25);
            this.userNameOutputLabel.TabIndex = 9;
            this.userNameOutputLabel.Text = "[Username]";
            // 
            // EmailOutputLabel
            // 
            this.EmailOutputLabel.AutoSize = true;
            this.EmailOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailOutputLabel.Location = new System.Drawing.Point(193, 247);
            this.EmailOutputLabel.Name = "EmailOutputLabel";
            this.EmailOutputLabel.Size = new System.Drawing.Size(72, 25);
            this.EmailOutputLabel.TabIndex = 10;
            this.EmailOutputLabel.Text = "[Email]";
            // 
            // MemberProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 696);
            this.Controls.Add(this.EmailOutputLabel);
            this.Controls.Add(this.userNameOutputLabel);
            this.Controls.Add(this.IdOutputLabel);
            this.Controls.Add(this.NameOutputLabel);
            this.Controls.Add(this.BorrowedBooksListView);
            this.Controls.Add(this.BorrowedBooksLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.memberIdlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberProfileLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MemberProfileForm";
            this.Text = "MemberProfileForm";
            this.Load += new System.EventHandler(this.MemberProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberProfileLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label memberIdlabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BorrowedBooksLabel;
        private System.Windows.Forms.ListView BorrowedBooksListView;
        private System.Windows.Forms.Label NameOutputLabel;
        private System.Windows.Forms.Label IdOutputLabel;
        private System.Windows.Forms.Label userNameOutputLabel;
        private System.Windows.Forms.Label EmailOutputLabel;
    }
}