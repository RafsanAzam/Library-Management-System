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
    public partial class LibrarianProfileForm : Form
    {
        private List<string> librarianDetailsList = new List<string>();
        public LibrarianProfileForm()
        {
            InitializeComponent();
        }

        private void LibrarianProfileForm_Load(object sender, EventArgs e)
        {
            string librarianId = CurrentLibrarian.LibrarianId;
            ExtractDetailsFromLibrarianFile(librarianId, "LibrarianDetails.txt");
            MessageBox.Show(librarianId);

            // Check if there are details to display
            if (librarianDetailsList.Count == 4)
            {
                NameOutputLabel.Text = librarianDetailsList[0];
                IdOutputLabel.Text = librarianDetailsList[1];
                userNameOutputLabel.Text = librarianDetailsList[2];
                EmailOutputLabel.Text = librarianDetailsList[3];
            }
            else
            {
               
                // Handle the case when details are not found
                MessageBox.Show("Librarian details not found for the given ID");
          
            }
        }

        private void ExtractDetailsFromLibrarianFile(string librarianId, string filePath)
        {
            //Read existing lines from the file
            //string[] existingLines = File.ReadAllLines(filePath);

            string[] lines = File.ReadAllLines(filePath);

            // Clear the librarianDetailsList to avoid multiple entries
            librarianDetailsList.Clear();

            foreach (string line in lines)
            {
                // Trim leading and trailing whitespace
                string trimmedLine = line.Trim();

                // Skip empty or whitespace-only lines
                if (string.IsNullOrWhiteSpace(trimmedLine))
                {
                    continue;
                }
                //librarianDetailsList.Clear();
                string[] librarianDetails = trimmedLine.Split(',');
                
                if (librarianDetails.Length == 6 && librarianDetails[0] == librarianId) // ".length == 6" because split counting last "," in the signup form
                {

                    // If the ID matches, add the member details to the list
                    librarianDetailsList.Add(librarianDetails[1]); // Name
                    librarianDetailsList.Add(librarianDetails[0]); // ID
                    librarianDetailsList.Add(librarianDetails[2]); // UserName
                    librarianDetailsList.Add(librarianDetails[3]); // Email

                }

            }
        }


        private void memberIdlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
