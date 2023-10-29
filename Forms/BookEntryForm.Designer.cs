namespace Library_Management_System.Forms
{
    partial class BookEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookEntryForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BookEntryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.TitletextBox = new System.Windows.Forms.TextBox();
            this.AuthortextBox = new System.Windows.Forms.TextBox();
            this.IsbntextBox = new System.Windows.Forms.TextBox();
            this.AddBookButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BookEntryLabel
            // 
            this.BookEntryLabel.AutoSize = true;
            this.BookEntryLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.BookEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookEntryLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BookEntryLabel.Location = new System.Drawing.Point(130, 77);
            this.BookEntryLabel.Name = "BookEntryLabel";
            this.BookEntryLabel.Size = new System.Drawing.Size(263, 38);
            this.BookEntryLabel.TabIndex = 2;
            this.BookEntryLabel.Text = "Book Entry Form";
            this.BookEntryLabel.Click += new System.EventHandler(this.BookEntryLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(43, 196);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(61, 29);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AuthorLabel.Location = new System.Drawing.Point(43, 254);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(82, 29);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author";
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.AutoSize = true;
            this.IsbnLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.IsbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsbnLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsbnLabel.Location = new System.Drawing.Point(43, 309);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(69, 29);
            this.IsbnLabel.TabIndex = 5;
            this.IsbnLabel.Text = "ISBN";
            this.IsbnLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TitletextBox
            // 
            this.TitletextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitletextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.TitletextBox.Location = new System.Drawing.Point(157, 195);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(218, 30);
            this.TitletextBox.TabIndex = 6;
            this.TitletextBox.Text = "Title";
            this.TitletextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titleTextBoxMouseClick);
            // 
            // AuthortextBox
            // 
            this.AuthortextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.AuthortextBox.Location = new System.Drawing.Point(157, 254);
            this.AuthortextBox.Name = "AuthortextBox";
            this.AuthortextBox.Size = new System.Drawing.Size(218, 30);
            this.AuthortextBox.TabIndex = 8;
            this.AuthortextBox.Text = "Author Name";
            this.AuthortextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AuthorTextBoxMouseClick);
            // 
            // IsbntextBox
            // 
            this.IsbntextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.IsbntextBox.Location = new System.Drawing.Point(157, 309);
            this.IsbntextBox.Name = "IsbntextBox";
            this.IsbntextBox.Size = new System.Drawing.Size(218, 30);
            this.IsbntextBox.TabIndex = 10;
            this.IsbntextBox.Text = "ISBN No.";
            this.IsbntextBox.Click += new System.EventHandler(this.IsbnTextBoxMouseClick);
            // 
            // AddBookButton2
            // 
            this.AddBookButton2.BackColor = System.Drawing.Color.CadetBlue;
            this.AddBookButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBookButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddBookButton2.Location = new System.Drawing.Point(128, 394);
            this.AddBookButton2.Name = "AddBookButton2";
            this.AddBookButton2.Size = new System.Drawing.Size(139, 54);
            this.AddBookButton2.TabIndex = 11;
            this.AddBookButton2.Text = "Add";
            this.AddBookButton2.UseVisualStyleBackColor = false;
            this.AddBookButton2.Click += new System.EventHandler(this.AddBookButton2_Click);
            // 
            // BookEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 578);
            this.Controls.Add(this.AddBookButton2);
            this.Controls.Add(this.IsbntextBox);
            this.Controls.Add(this.AuthortextBox);
            this.Controls.Add(this.TitletextBox);
            this.Controls.Add(this.IsbnLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BookEntryLabel);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookEntryForm";
            this.Text = "Book Entry Form";
            this.Load += new System.EventHandler(this.BookEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BookEntryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.TextBox TitletextBox;
        private System.Windows.Forms.TextBox AuthortextBox;
        private System.Windows.Forms.TextBox IsbntextBox;
        private System.Windows.Forms.Button AddBookButton2;
    }
}