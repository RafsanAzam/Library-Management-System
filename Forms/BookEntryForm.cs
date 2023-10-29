using Library_Management_System.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Forms
{
    public partial class BookEntryForm : Form
    {
        LibrarianBookListForm librarianForm = new LibrarianBookListForm();
        public BookEntryForm()
        {
            InitializeComponent();
        }

        private void BookEntryLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddBookButton2_Click(object sender, EventArgs e)
        {
            string title = TitletextBox.Text;
            string author = AuthortextBox.Text;
            string isbn = IsbntextBox.Text;

            //Create a new Book object with the input data

            Book newBook = new Book
            {
                Title = title,
                Author = author,
                ISBN = isbn,
                IsAvailable = true,
            };

            AddBookToListViewAndFile(newBook);
            librarianForm.BookListViewLibrarian.Refresh();
            MessageBox.Show("Book entry is successful");
            this.Close();

        }

        private void AddBookToListViewAndFile(Book newBook)
        {
            //Add the new book to the ListView
            ListViewItem item = new ListViewItem(newBook.BookId);
            item.SubItems.Add(newBook.Title);
            item.SubItems.Add(newBook.Author);
            item.SubItems.Add(newBook.ISBN);
            item.SubItems.Add(newBook.IsAvailable ? "Available" : "Not Available" );
            librarianForm.BookListViewLibrarian.Items.Add(item);

            // Append the new book's details to the text file
            using (StreamWriter writer = File.AppendText("BookList.txt"))
            {
                writer.WriteLine($"{newBook.BookId},{newBook.Title},{newBook.Author},{newBook.ISBN},{newBook.IsAvailable}");
            }
        }

        private void BookEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void titleTextBoxMouseClick(object sender, MouseEventArgs e)
        {
            if(TitletextBox.Text == "Title")
            {
                TitletextBox.Clear();
            }
        }

        private void AuthorTextBoxMouseClick(object sender, MouseEventArgs e)
        {
            if(AuthortextBox.Text == "Author")
            {
                AuthortextBox.Clear();
            }
        }

        private void IsbnTextBoxMouseClick(object sender, EventArgs e)
        {
            if(IsbntextBox.Text == "ISBN No.")
            {
                IsbntextBox.Clear();
            }
        }
    }
}
