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
    public partial class LibrarianDashboardForm : Form
    {
        public LibrarianDashboardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            LibrarianProfileForm librarianProfileForm = new LibrarianProfileForm();
            librarianProfileForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateBooksBtn_Click(object sender, EventArgs e)
        {
            LibrarianBookListForm librarianBookListForm = new LibrarianBookListForm();
            librarianBookListForm.Show();
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void LibrarianDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void ViewLibraryButton_Click(object sender, EventArgs e)
        {
            ViewLibraryForm viewLibraryForm = new ViewLibraryForm();
            viewLibraryForm.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
