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
            this.memberId = new System.Windows.Forms.Label();
            this.MemberIdView = new System.Windows.Forms.Label();
            this.memberName = new System.Windows.Forms.Label();
            this.memberNameView = new System.Windows.Forms.Label();
            this.memberEmail = new System.Windows.Forms.Label();
            this.memberEmailView = new System.Windows.Forms.Label();
            this.updateProfileButton = new System.Windows.Forms.Button();
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
            // memberId
            // 
            this.memberId.AutoSize = true;
            this.memberId.Location = new System.Drawing.Point(41, 234);
            this.memberId.Name = "memberId";
            this.memberId.Size = new System.Drawing.Size(108, 25);
            this.memberId.TabIndex = 2;
            this.memberId.Text = "Member ID";
            this.memberId.Click += new System.EventHandler(this.label2_Click);
            // 
            // MemberIdView
            // 
            this.MemberIdView.AutoSize = true;
            this.MemberIdView.Location = new System.Drawing.Point(205, 234);
            this.MemberIdView.Name = "MemberIdView";
            this.MemberIdView.Size = new System.Drawing.Size(143, 25);
            this.MemberIdView.TabIndex = 4;
            this.MemberIdView.Text = "memberId.view";
            // 
            // memberName
            // 
            this.memberName.AutoSize = true;
            this.memberName.Location = new System.Drawing.Point(41, 283);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(141, 25);
            this.memberName.TabIndex = 5;
            this.memberName.Text = "Member Name";
            // 
            // memberNameView
            // 
            this.memberNameView.AutoSize = true;
            this.memberNameView.Location = new System.Drawing.Point(207, 283);
            this.memberNameView.Name = "memberNameView";
            this.memberNameView.Size = new System.Drawing.Size(224, 31);
            this.memberNameView.TabIndex = 6;
            this.memberNameView.Text = "memberName.view";
            // 
            // memberEmail
            // 
            this.memberEmail.AutoSize = true;
            this.memberEmail.Location = new System.Drawing.Point(45, 325);
            this.memberEmail.Name = "memberEmail";
            this.memberEmail.Size = new System.Drawing.Size(137, 25);
            this.memberEmail.TabIndex = 7;
            this.memberEmail.Text = "Member Email";
            // 
            // memberEmailView
            // 
            this.memberEmailView.AutoSize = true;
            this.memberEmailView.Location = new System.Drawing.Point(205, 325);
            this.memberEmailView.Name = "memberEmailView";
            this.memberEmailView.Size = new System.Drawing.Size(219, 31);
            this.memberEmailView.TabIndex = 8;
            this.memberEmailView.Text = "memberEmail.view";
            // 
            // updateProfileButton
            // 
            this.updateProfileButton.AutoSize = true;
            this.updateProfileButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.updateProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfileButton.ForeColor = System.Drawing.Color.Transparent;
            this.updateProfileButton.Location = new System.Drawing.Point(105, 421);
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Size = new System.Drawing.Size(243, 54);
            this.updateProfileButton.TabIndex = 9;
            this.updateProfileButton.Text = "Update Profile";
            this.updateProfileButton.UseVisualStyleBackColor = false;
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 679);
            this.Controls.Add(this.updateProfileButton);
            this.Controls.Add(this.memberEmailView);
            this.Controls.Add(this.memberEmail);
            this.Controls.Add(this.memberNameView);
            this.Controls.Add(this.memberName);
            this.Controls.Add(this.MemberIdView);
            this.Controls.Add(this.memberId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberDashboard";
            this.Text = "Member Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label memberId;
        private System.Windows.Forms.Label MemberIdView;
        private System.Windows.Forms.Label memberName;
        private System.Windows.Forms.Label memberNameView;
        private System.Windows.Forms.Label memberEmail;
        private System.Windows.Forms.Label memberEmailView;
        private System.Windows.Forms.Button updateProfileButton;
    }
}