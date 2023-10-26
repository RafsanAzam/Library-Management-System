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
    public partial class MemberDashboardForm : Form
    {
        public MemberDashboardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MemberDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void ViewLibraryButton_Click(object sender, EventArgs e)
        {
            ViewLibraryForm viewLibraryForm = new ViewLibraryForm();
            viewLibraryForm.Show();
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowBookForm = new BorrowBookForm();
            borrowBookForm.Show();           
        }
    }
}
