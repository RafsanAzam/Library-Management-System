using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataModels
{
    public class Member
    {
        //Static variable to track the last assigned LibrairanId
        private static int lastAssignedMemberId;
        public string MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Member()
        {
            if (lastAssignedMemberId == 0)
            {
                lastAssignedMemberId = LoadLastMemberID();
            }
            //Auto-generate the MemberId with "M" prefix
            MemberId = "M" + ((++lastAssignedMemberId).ToString());
        }

        private int LoadLastMemberID()
        {
            int lastMemberID = 0; //Default value if the file is not found or the file is blank

            string filePath = "memberDetails.txt";

            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines.Length > 0)
                    {
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');

                            if (parts.Length > 0 && parts[0].StartsWith("M") && int.TryParse(parts[0].Substring(1), out int currentMemberID))
                            {
                                lastMemberID = currentMemberID;
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine($"Error reading the file");
                }
            }

            return lastMemberID;
        }


    }
}
