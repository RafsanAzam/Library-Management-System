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
    public partial class WelcomeDashboardForm : Form
    {
      
        public WelcomeDashboardForm()
        {
            InitializeComponent();
        }

        private void WelcomeDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void visitLibraryBtn_Click(object sender, EventArgs e)
        {
            ViewLibraryForm viewLibraryForm = new ViewLibraryForm();
            viewLibraryForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }
    }
}
