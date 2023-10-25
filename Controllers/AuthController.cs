using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Controllers
{
    public class AuthController
    {
        private string filePath;
        public AuthController(string credentialsFilePath)
        {
            filePath = credentialsFilePath; // where all the credentials are saved.
        }

        public string Authenticate(string userName,  string password)
        {
            String[] lines = File.ReadAllLines(filePath); // saving all the credentials in a string array.
            foreach (String line in lines) 
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3) 
                {
                    string storedUserName = parts[0];
                    string storedPassword = parts[1];
                    string storedRole = parts[2];

                    if(userName == storedUserName && password == storedPassword)
                    {
                        return storedRole; // Authentication successful
                    }
                }
            }

            return "Authentication failed"; // Authentication failed 
        }
    }
}
