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
    public partial class BorrowBookForm : Form
    {
        public List<Book> books = new List<Book>();
        public List<BorrowedBook> memberBorrowedBooks = new List<BorrowedBook>();
        public BorrowedBook borrowedBook { get; set; }
        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            LoadAvailableBooks();
        }

        private void LoadAvailableBooks()
        {
            // Read the list of available books from data source
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
                if (bookDetails.Length == 5)
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

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchtextBox.Text.ToLower(); // Convert to lowercase for case-insensitive search

            // Clear the existing items in the ListView 
            bookListViewLibrarian.Items.Clear();

            foreach (var book in books)
            {
                string title = book.Title.ToLower();

                // Check if the title contains the search query
                if (title.Contains(searchQuery))
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

        private void SearchtextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (SearchtextBox.Text == "Search Books")
            {
                SearchtextBox.Clear();
            }
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected 
            if(bookListViewLibrarian.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = bookListViewLibrarian.SelectedItems[0];

                //Get the book ID from the selected item
                string bookId = selectedItem.SubItems[0].Text;

                // Find the selected book in your books list
                Book selectedBook = books.Find(book => book.BookId == bookId);

                if (selectedBook != null && selectedBook.IsAvailable)
                {
                    // store the logged in member's ID
                    string memberID = CurrentMember.MemberId;
                    //generate a unique member file Name
                    string memberFileName = memberID + "_BorrowedBooks.txt";
                    // Create a new Borrowed Book object
                    borrowedBook = new BorrowedBook
                    {
                        BookId = selectedBook.BookId,
                        Title = selectedBook.Title,
                        Author = selectedBook.Author,
                        ISBN = selectedBook.ISBN
                    };
                    // Add the borrowed book to the member's list of borrowed book
                    memberBorrowedBooks.Add(borrowedBook);
                    SaveMemberBorrowedBooks(memberFileName, memberBorrowedBooks);

                    // Update the book's availability
                    selectedBook.IsAvailable = false;

                    //save the updated book list to the file
                    WriteBooksToFile("BookList.txt", books);

                    //Refresh the listView to update the display
                    RefreshListView();
                    MessageBox.Show("You have successfully borrowed the book!");

                }

                else
                {
                    MessageBox.Show("The selected book is not available for borrowing.");
                }


            }
            else
            {
                MessageBox.Show("Please select a book to borrow.");
            }
        }

        private void RefreshListView()
        {
            // Clear the existing items in the ListView
            bookListViewLibrarian.Items.Clear();

            // Re-populate the ListView with the updated book data
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

        private void WriteBooksToFile(string filePath, List<Book> books)
        {
            List<string> lines = new List<string>();

            foreach (var book in books)
            {
                string bookDetails = $"{book.BookId},{book.Title},{book.Author},{book.ISBN},{book.IsAvailable}";
                lines.Add(bookDetails);
            }

            File.WriteAllLines(filePath, lines);
        }

        private void SaveMemberBorrowedBooks(string filePath, List<BorrowedBook>memberBorrowedBooks)
        {
            List<string> lines = new List<string>();

            foreach (var borrowedBook in memberBorrowedBooks)
            {
                string bookDetails = $"{borrowedBook.BookId},{borrowedBook.Title},{borrowedBook.Author},{borrowedBook.ISBN}";
                lines.Add(bookDetails);
            }


            if (!File.Exists(filePath))
            {
                // Create a new file with initial data
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                // Append or update the existing file
                File.AppendAllLines(filePath, lines);
            }

        }

    }
}
