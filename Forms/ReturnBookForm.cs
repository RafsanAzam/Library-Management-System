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
    public partial class ReturnBookForm : Form
    {
        public List<BorrowedBook> memberBorrowedBooks = new List<BorrowedBook>();
        public List<Book> books = new List<Book>();
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void bookListViewLibrarian_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            if(bookListViewMember.Items.Count > 0)
            {
                ListViewItem selectedItem = bookListViewMember.SelectedItems[0];

                // Get the bookId from the selected item
                string bookId = selectedItem.SubItems[0].Text;

                // Find the selected book in the member's borrowed books list

                BorrowedBook borrowedBook = memberBorrowedBooks.Find(book => book.BookId == bookId);

                if(borrowedBook != null)
                {
                    // Remove the book from the member's borrowed books list
                    memberBorrowedBooks.Remove(borrowedBook);

                    // Update the books availability to "Available"
                    Book selectedBook = books.Find(book => book.BookId == bookId);

                    if(selectedBook != null)
                    {
                        selectedBook.IsAvailable = true;

                        // Save the updated book list to the file
                        WriteBooksToFile("BookList.txt", books);
                    }

                    // Save the updated member's borrowed books list to their file
                    string memberID = CurrentMember.MemberId;
                    string membersFileName = memberID + "_BorrowedBooks.txt";
                    SaveMemberBorrowedBooks(membersFileName, memberBorrowedBooks);

                    // Refresh the listView of borrowed books to update the display

                    RefreshListView();
                }
                else
                {
                    MessageBox.Show("The selected book is not in your borrowed books list.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return!");
            }
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            bookListViewMember.Items.Clear();
            LoadBorrowedBooks();
            LoadLibraryBookList();
        }

        private void LoadBorrowedBooks()
        {
            
            //Define and add columns with headers
            bookListViewMember.View = View.Details;
            bookListViewMember.Columns.Add("Book ID", 80);
            bookListViewMember.Columns.Add("Title", 200);
            bookListViewMember.Columns.Add("Author", 150);
            bookListViewMember.Columns.Add("ISBN", 100);


            // Read book details from the file and populate the list
            string memberFileName = CurrentMember.MemberId + "_BorrowedBooks.txt";

            string[] lines = File.ReadAllLines(memberFileName);

            foreach (string line in lines)
            {
                string[] bookDetails = line.Split(',');
                if (bookDetails.Length == 4)
                {
                    BorrowedBook book = new BorrowedBook()
                    {
                        BookId = bookDetails[0],
                        Title = bookDetails[1],
                        Author = bookDetails[2],
                        ISBN = bookDetails[3],
                    };
                    memberBorrowedBooks.Add(book);
                }

            }

            // Populate the ListView with book data

            foreach (var book in memberBorrowedBooks)
            {
                ListViewItem item = new ListViewItem(book.BookId);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.ISBN);
                bookListViewMember.Items.Add(item);
            }

        }

        private void LoadLibraryBookList()
        {
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

        private void SaveMemberBorrowedBooks(string filePath, List<BorrowedBook> memberBorrowedBooks)
        {
            List<string> lines = new List<string>();

            foreach (var borrowedBook in memberBorrowedBooks)
            {
                string bookDetails = $"{borrowedBook.BookId},{borrowedBook.Title},{borrowedBook.Author},{borrowedBook.ISBN}";
                lines.Add(bookDetails);
            }
            File.WriteAllLines(filePath, lines);
        }

        private void RefreshListView()
        {
            // Clear the existing items in the ListView
            bookListViewMember.Items.Clear();

            // Re-populate the ListView with the updated member borrowed book data
            foreach (var book in memberBorrowedBooks)
            {
                ListViewItem item = new ListViewItem(book.BookId);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.ISBN);
                bookListViewMember.Items.Add(item);
            }
        }
    }
}
