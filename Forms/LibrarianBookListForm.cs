using Library_Management_System.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Forms
{
    public partial class LibrarianBookListForm : Form
    {
        //declaring this list from the class level so that other forms can also access this book list.
        public List<Book> books = new List<Book>();
        public LibrarianBookListForm()
        {
            InitializeComponent();
        }

        private void LibrarianBookListForm_Load(object sender, EventArgs e)
        {
            //Initialize a list to hold 
           //List<Book> books = new List<Book>();


            //Define and add columns with headers
            bookListViewLibrarian.View = View.Details;
            bookListViewLibrarian.Columns.Add("Book ID", 80);
            bookListViewLibrarian.Columns.Add("Title", 200);
            bookListViewLibrarian.Columns.Add("Author", 150);
            bookListViewLibrarian.Columns.Add("ISBN", 100);
            bookListViewLibrarian.Columns.Add("Availability", 100);

            // Read book details from the file and populate the list

            string[] lines = File.ReadAllLines("BookList.txt");

            foreach (string line in lines)
            {
                string[] bookDetails = line.Split(',');
                if(bookDetails.Length == 5)
                {
                    Book book = new Book()
                    {
                        BookId = bookDetails[0],
                        Title = bookDetails[1],
                        Author = bookDetails[2],
                        ISBN = bookDetails[3],
                        IsAvailable = bool.Parse(bookDetails[4])
                    };
                    books.Add(book);
                }
               
            }

            // Populate the ListView with book data

            foreach (var book in books)
            {
                ListViewItem item = new ListViewItem(book.BookId);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.ISBN);
                item.SubItems.Add(book.IsAvailable ? "Available" : "Not Available");
                bookListViewLibrarian.Items.Add(item);
            }
        }

        private void bookListViewLibrarian_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
           BookEntryForm bookEntryForm = new BookEntryForm();
            bookEntryForm.Show();
        }

        /*public List<Book> BooksList
        { 
            get { return books; }
            set { books = value; }
        }*/

        public ListView BookListViewLibrarian
        {
            get { return bookListViewLibrarian; }
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            //check if an item is selected 
            if (bookListViewLibrarian.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = bookListViewLibrarian.SelectedItems[0];

                //Get the book ID from the selected item 
                string bookId = selectedItem.SubItems[0].Text;

                //Ask for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    //Remove the selected item from the ListView
                    bookListViewLibrarian.Items.Remove(selectedItem);

                    //Delete the book from the data source (the text file)
                    DeleteBookFromFile(bookId);

                    //Refresh the ListView to update the display
                    bookListViewLibrarian.Refresh();
                }

                else
                {
                    MessageBox.Show("Please select a book to delete.", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DeleteBookFromFile(string bookId)
        {
            //Read the existing lines from file
            string[] lines = File.ReadAllLines("BookList.txt");

            // Create a new list to store the updated lines
            List<string> updatedLines = new List<string>();
            
            // Iterate through the lines and exclude the line with the matching book ID

            foreach (string line in lines)
            {
                string[] bookDetails = line.Split(',');
                if (bookDetails.Length >= 5  && bookDetails[0]!= bookId)
                {
                    updatedLines.Add(line);
                }
            }

            // write the updated lines back to the text file effectively deleting the book

            File.WriteAllLines("BookList.txt", updatedLines);


        }

        private void SearchtextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (SearchtextBox.Text == "Search Books")
            {
                SearchtextBox.Clear();
            }
        }
        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchtextBox.Text.ToLower(); // Convert to lowercase for case-insensitive search

            // Clear the existing items in the ListView 
            bookListViewLibrarian.Items.Clear();

            foreach (var book in books)
            {
                string title = book.Title.ToLower();

                // Check if the title contains the search query
                if(title.Contains(searchQuery))
                {
                    ListViewItem item = new ListViewItem(book.BookId);
                    item.SubItems.Add(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.ISBN);
                    item.SubItems.Add(book.IsAvailable ? "Available" : "Not Available");
                    bookListViewLibrarian.Items.Add(item);
                }


            }
            

        }
    }
}
