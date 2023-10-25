namespace Library_Management_System.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.RoleGroupBox = new System.Windows.Forms.GroupBox();
            this.MemberButton = new System.Windows.Forms.RadioButton();
            this.LibrarianButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RoleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(68, 301);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(320, 30);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(68, 359);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(320, 30);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(68, 418);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 30);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Email";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(68, 479);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(320, 30);
            this.txtNewPassword.TabIndex = 7;
            this.txtNewPassword.Text = "New password";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword.Location = new System.Drawing.Point(68, 536);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(320, 30);
            this.txtRetypePassword.TabIndex = 8;
            this.txtRetypePassword.Text = "Retype Password";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.Cyan;
            this.SignUpButton.Location = new System.Drawing.Point(92, 600);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(243, 54);
            this.SignUpButton.TabIndex = 9;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            // 
            // RoleGroupBox
            // 
            this.RoleGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.RoleGroupBox.Controls.Add(this.MemberButton);
            this.RoleGroupBox.Controls.Add(this.LibrarianButton);
            this.RoleGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RoleGroupBox.Location = new System.Drawing.Point(68, 195);
            this.RoleGroupBox.Name = "RoleGroupBox";
            this.RoleGroupBox.Size = new System.Drawing.Size(200, 100);
            this.RoleGroupBox.TabIndex = 13;
            this.RoleGroupBox.TabStop = false;
            this.RoleGroupBox.Text = "Role:";
            this.RoleGroupBox.Enter += new System.EventHandler(this.RoleGroupBox_Enter);
            // 
            // MemberButton
            // 
            this.MemberButton.AutoSize = true;
            this.MemberButton.BackColor = System.Drawing.SystemColors.Control;
            this.MemberButton.Location = new System.Drawing.Point(6, 62);
            this.MemberButton.Name = "MemberButton";
            this.MemberButton.Size = new System.Drawing.Size(105, 29);
            this.MemberButton.TabIndex = 1;
            this.MemberButton.TabStop = true;
            this.MemberButton.Text = "Member";
            this.MemberButton.UseVisualStyleBackColor = false;
            // 
            // LibrarianButton
            // 
            this.LibrarianButton.AutoSize = true;
            this.LibrarianButton.BackColor = System.Drawing.SystemColors.Control;
            this.LibrarianButton.Location = new System.Drawing.Point(6, 29);
            this.LibrarianButton.Name = "LibrarianButton";
            this.LibrarianButton.Size = new System.Drawing.Size(108, 29);
            this.LibrarianButton.TabIndex = 0;
            this.LibrarianButton.TabStop = true;
            this.LibrarianButton.Text = "Librarian";
            this.LibrarianButton.UseVisualStyleBackColor = false;
            this.LibrarianButton.CheckedChanged += new System.EventHandler(this.LibrarianButton_CheckedChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.RoleGroupBox);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.txtRetypePassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RoleGroupBox.ResumeLayout(false);
            this.RoleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.GroupBox RoleGroupBox;
        private System.Windows.Forms.RadioButton MemberButton;
        private System.Windows.Forms.RadioButton LibrarianButton;
    }
}