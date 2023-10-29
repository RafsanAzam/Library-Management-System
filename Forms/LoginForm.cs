using Library_Management_System.Controllers;
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
    public partial class LoginForm : Form
    {
        private AuthController authController;
        public LoginForm()
        {
            InitializeComponent();
            authController = new AuthController("UserCredentials.txt");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Username")
            {
                txtUserName.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Get the entered user ID & password
            string enteredUserName = txtUserName.Text;
            string enteredPassword = txtPassword.Text;

            // Authenticate the user

            if(authController.Authenticate(enteredUserName, enteredPassword) == "Member")
            {
                // Successful login
                MessageBox.Show("Login successful. Redirect to the member dashboard");

                // Set the member's ID in the currentMember Class
                CurrentMember.MemberId = enteredUserName;
                //Create an istance of the Member Dashboard Form
                MemberDashboardForm memberDashboard = new MemberDashboardForm();

                // Show the Member Dashboard Form
                this.Close();
                memberDashboard.Show();
            }
            else if(authController.Authenticate(enteredUserName, enteredPassword) == "Librarian")
            {
                // Successful login
                MessageBox.Show("Login successful. Redirect to the Librarian dashboard");

                // Set the member's ID in the currentMember Class
                CurrentLibrarian.LibrarianId = enteredUserName;

                //Create an istance of the Librarian Dashboard Form
                LibrarianDashboardForm librarianDashboard = new LibrarianDashboardForm();

                // Show the Librarian Dashboard Form
                this.Close();
                librarianDashboard.Show();
            }
            else
            {
                //Authentication failed
                MessageBox.Show("Login failed. Incorrect user ID or password.");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Close();
            signUpForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
