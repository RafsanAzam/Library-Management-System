using Library_Management_System.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Forms
{
    public partial class EditBookForm : Form
    {
        public Book EditedBook { get; set; }
        public EditBookForm(Book bookToEdit)
        {
            InitializeComponent();

            // Initialize the form with the current book details
            TitletextBox.Text = bookToEdit.Title;
            AuthorTextBox.Text = bookToEdit.Author;
            IsbnTextBox.Text = bookToEdit.ISBN;
            yesButton.Checked = bookToEdit.IsAvailable;
            noButton.Checked = !bookToEdit.IsAvailable;
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //When the user click "Update," create the EditedBook object
            EditedBook = new Book
            {
                Title = TitletextBox.Text,
                Author = AuthorTextBox.Text,
                ISBN = IsbnTextBox.Text,
                IsAvailable = yesButton.Checked
            };

            // Close the EditBookForm
            this.DialogResult = DialogResult.OK; // Indicates that the operation was successful
            this.Close();
        }

        private void YesButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
