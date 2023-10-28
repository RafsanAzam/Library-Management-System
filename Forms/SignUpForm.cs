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
    public partial class SignUpForm : Form
    {
        public Librarian librarian { get; set; }
        public Member member { get; set; }
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void LibrarianButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RoleGroupBox_Enter(object sender, EventArgs e)
        {

        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //Get user input from the form's controls
            string Name = txtFullName.Text;
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Check if the user selected the librarian or Memeber role
            string role = LibrarianButton.Checked ? "Librarian" : "Member";

            // Validation & Registration Logic here
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required field");
            }
            else
            {
                if(role == "Librarian")
                {
                    librarian = new Librarian
                    {
                        Name = Name,
                        Username = userName,
                        Email = email,
                        Password = password
                    };
                    WriteDetailsToLibrarianFile(librarian, "LibrarianDetails.txt");
                    WriteDetailsToCredentialsFile("UserCredentials.txt", librarian.LibrarianId, password, "Librarian");
                    MessageBox.Show($"Successfully Registered. Your User Id is : {librarian.LibrarianId}");
                }
                else
                {
                    member = new Member
                    {
                        Name = Name,
                        Username = userName,
                        Email = email,
                        Password = password
                    };
                    WriteDetailsToMemberFile(member, "memberDetails.txt");
                    WriteDetailsToCredentialsFile("UserCredentials.txt", member.MemberId, password, "Member");
                    MessageBox.Show($"Successfully Registered. Your User Id is : {member.MemberId}");
                }
            }
        }
        private void WriteDetailsToLibrarianFile(Librarian libraian, string filePath)
        {
            //Read existing lines from the file
            string[] existingLines = File.ReadAllLines(filePath);

            //Add the new librarian's data to the existing lines
            string librarianDetails = $"{libraian.LibrarianId},{libraian.Name},{libraian.Username},{libraian.Email},{libraian.Password},";
            List<string> UpdatedLines = new List<string>(existingLines);
            UpdatedLines.Add(librarianDetails);

            //Write the updated data back to the file
            File.WriteAllLines(filePath, UpdatedLines);
        }

        private void WriteDetailsToMemberFile(Member member, string filePath)
        {
            //Read existing lines from the file
            string[] existingLines = File.ReadAllLines(filePath);

            //Add the new member's data to the existing lines
            string memberDetails = $"{member.MemberId},{member.Name},{member.Username},{member.Email},{member.Password},";
            List<string> UpdatedLines = new List<string>(existingLines);
            UpdatedLines.Add(memberDetails);

            //Write the updated data back to the file
            File.WriteAllLines(filePath, UpdatedLines);
        }

        private void WriteDetailsToCredentialsFile(string filePath, String Id, string Password, String Role)
        {
            //Read existing lines from the file
            string[] existingLines = File.ReadAllLines(filePath);

            //Add the new credentials data to the existing lines
            string credentialDetails = $"{Id},{Password},{Role}";
            List<string> UpdatedLines = new List<string>(existingLines);
            UpdatedLines.Add(credentialDetails);

            //Write the updated data back to the file
            File.WriteAllLines(filePath, UpdatedLines);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_Tged(object sender, EventArgs e)
        {

        }

        private void NameTxtClicked(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Name")
            {
                txtFullName.Clear();
            }
        }

        private void txtUserNameMouseClick(object sender, EventArgs e)
        {
            if (txtUserName.Text == "User Name")
            {
                txtUserName.Clear();
            }
        }

        private void txtEmailMouseClick(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
        }

        private void txtPasswordMouseClick(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
