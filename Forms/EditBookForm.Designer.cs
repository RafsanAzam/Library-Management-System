namespace Library_Management_System.Forms
{
    partial class EditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BookEditLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitletextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Availability = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.RadioButton();
            this.noButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BookEditLabel
            // 
            this.BookEditLabel.AutoSize = true;
            this.BookEditLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.BookEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookEditLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BookEditLabel.Location = new System.Drawing.Point(166, 70);
            this.BookEditLabel.Name = "BookEditLabel";
            this.BookEditLabel.Size = new System.Drawing.Size(266, 38);
            this.BookEditLabel.TabIndex = 3;
            this.BookEditLabel.Text = "Edit Book Details";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(99, 196);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(61, 29);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // TitletextBox
            // 
            this.TitletextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitletextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitletextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.TitletextBox.Location = new System.Drawing.Point(187, 196);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(232, 27);
            this.TitletextBox.TabIndex = 7;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AuthorLabel.Location = new System.Drawing.Point(99, 248);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(82, 29);
            this.AuthorLabel.TabIndex = 8;
            this.AuthorLabel.Text = "Author";
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.AutoSize = true;
            this.IsbnLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.IsbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsbnLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsbnLabel.Location = new System.Drawing.Point(99, 296);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(69, 29);
            this.IsbnLabel.TabIndex = 9;
            this.IsbnLabel.Text = "ISBN";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.AuthorTextBox.Location = new System.Drawing.Point(187, 248);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(232, 27);
            this.AuthorTextBox.TabIndex = 10;
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IsbnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsbnTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.IsbnTextBox.Location = new System.Drawing.Point(187, 300);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(232, 27);
            this.IsbnTextBox.TabIndex = 11;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.CadetBlue;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UpdateButton.Location = new System.Drawing.Point(200, 488);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(139, 54);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Availability
            // 
            this.Availability.AutoSize = true;
            this.Availability.BackColor = System.Drawing.Color.CadetBlue;
            this.Availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availability.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Availability.Location = new System.Drawing.Point(99, 357);
            this.Availability.Name = "Availability";
            this.Availability.Size = new System.Drawing.Size(126, 29);
            this.Availability.TabIndex = 13;
            this.Availability.Text = "Availability";
            this.Availability.Click += new System.EventHandler(this.label1_Click);
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.BackColor = System.Drawing.Color.CadetBlue;
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(255, 357);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(67, 29);
            this.yesButton.TabIndex = 14;
            this.yesButton.TabStop = true;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.BackColor = System.Drawing.Color.CadetBlue;
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(328, 357);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(58, 29);
            this.noButton.TabIndex = 15;
            this.noButton.TabStop = true;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 692);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.Availability);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.IsbnLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitletextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BookEditLabel);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EditBookForm";
            this.Text = "Edit Book Form";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BookEditLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitletextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label Availability;
        private System.Windows.Forms.RadioButton yesButton;
        private System.Windows.Forms.RadioButton noButton;
    }
}