using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataModels
{
    public class Librarian
    {
        //Static variable to track the last assigned LibrairanId
        private static int lastAssignedLibrarianId;
        public string LibrarianId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Librarian()
        {
            lastAssignedLibrarianId = LoadLastLibrarianID();
            //Auto-generate the LibrarianId with "L" prefix
            LibrarianId = "L" + ((++lastAssignedLibrarianId).ToString());
            
        }

        private int LoadLastLibrarianID()
        {
            int lastLibrarianID = 0; //Default value if the file is not found or the file is blank

            string filePath = "LibrarianDetails.txt";

            if(File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    if(lines.Length > 0)
                    {
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');

                            if (parts.Length > 0 && parts[0].StartsWith("L") && int.TryParse(parts[0].Substring(1), out int currentLibrarianID))
                            {
                                lastLibrarianID = currentLibrarianID;
                            }
                        }
                    }
                }
                catch(IOException)
                {
                    Console.WriteLine($"Error reading the file");
                }
            }

            return lastLibrarianID;
        }
    }
}
