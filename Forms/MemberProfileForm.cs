using Library_Management_System.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Forms
{
    public partial class MemberProfileForm : Form
    {
        private List<string> memberDetailsList = new List<string>();
        private List<BorrowedBook>borrowedBooks = new List<BorrowedBook>();
        public MemberProfileForm()
        {
            InitializeComponent();
        }

        

        private void MemberProfileForm_Load(object sender, EventArgs e)
        {
            string memberId = CurrentMember.MemberId;
            ExtractDetailsFromMemberFile(memberId, "MemberDetails.txt");
            LoadBorrowedBooks();

            // Check if there are details to display
            if(memberDetailsList.Count == 4)
            {
                NameOutputLabel.Text = memberDetailsList[0];
                IdOutputLabel.Text = memberDetailsList[1];
                userNameOutputLabel.Text = memberDetailsList[2];
                EmailOutputLabel.Text = memberDetailsList[3];
            }
            else
            {
                // Handle the case when details are not found
                MessageBox.Show("Member details not found for the given ID");
            }
        }

        private void ExtractDetailsFromMemberFile(string memberId, string filePath)
        {
            //Read existing lines from the file
            string[] existingLines = File.ReadAllLines(filePath);

            string[] lines = File.ReadAllLines(filePath);

            // Clear the memberDetailsList to avoid multiple entries
            memberDetailsList.Clear();

            foreach (string line in lines)
            {
                string[] memberDetails = line.Split(',');
                if (memberDetails.Length ==6  && memberDetails[0] == memberId) // ".length == 6" because split counting last "," in the signup form
                {

                    // If the ID matches, add the member details to the list
                    memberDetailsList.Add(memberDetails[1]); // Name
                    memberDetailsList.Add(memberDetails[0]); // ID
                    memberDetailsList.Add(memberDetails[3]); // Email
                    memberDetailsList.Add(memberDetails[4]); // Username

                }

            }
        }

        private void LoadBorrowedBooks()
        {

            //Define and add columns with headers
            BorrowedBooksListView.View = View.Details;
            BorrowedBooksListView.Columns.Add("Book ID", 100);
            BorrowedBooksListView.Columns.Add("Title", 200);
            BorrowedBooksListView.Columns.Add("Author", 150);
            BorrowedBooksListView.Columns.Add("ISBN", 100);


            // Read book details from the file and populate the list
            string memberFileName = CurrentMember.MemberId + "_BorrowedBooks.txt";

            if(File.Exists(memberFileName))
            {
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
                        borrowedBooks.Add(book);
                    }

                }

                // Populate the ListView with book data

                foreach (var book in borrowedBooks)
                {
                    ListViewItem item = new ListViewItem(book.BookId);
                    item.SubItems.Add(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.ISBN);
                    BorrowedBooksListView.Items.Add(item);
                }
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BorrowedBooksListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BorrowedBooksLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
