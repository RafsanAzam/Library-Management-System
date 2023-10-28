namespace Library_Management_System.Forms
{
    partial class WelcomeDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeDashboardForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.visitLibraryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Plum;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.welcomeLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeLabel.Location = new System.Drawing.Point(499, 101);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(373, 46);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to The Library";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.LoginButton.Location = new System.Drawing.Point(520, 253);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(243, 54);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.MediumOrchid;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.SignUpButton.Location = new System.Drawing.Point(520, 322);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(243, 54);
            this.SignUpButton.TabIndex = 9;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // visitLibraryBtn
            // 
            this.visitLibraryBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.visitLibraryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitLibraryBtn.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitLibraryBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.visitLibraryBtn.Location = new System.Drawing.Point(520, 181);
            this.visitLibraryBtn.Name = "visitLibraryBtn";
            this.visitLibraryBtn.Size = new System.Drawing.Size(243, 54);
            this.visitLibraryBtn.TabIndex = 10;
            this.visitLibraryBtn.Text = "Book Visit";
            this.visitLibraryBtn.UseVisualStyleBackColor = false;
            this.visitLibraryBtn.Click += new System.EventHandler(this.visitLibraryBtn_Click);
            // 
            // WelcomeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 762);
            this.Controls.Add(this.visitLibraryBtn);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.welcomeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WelcomeDashboardForm";
            this.Text = "WelcomeDashboardForm";
            this.Load += new System.EventHandler(this.WelcomeDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button visitLibraryBtn;
    }
}