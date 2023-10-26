using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataModels
{
    public class Librarian
    {
        //Static variable to track the last assigned LibrairanId
        private static int lastAssignedLibrarianId = 0;
        public string LibrarianId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Librarian()
        {
            //Auto-generate the LibrarianId with "L" prefix
            LibrarianId = "L" + ((++lastAssignedLibrarianId).ToString());
        }
    }
}
