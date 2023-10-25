using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataModels
{
    public class Book
    {
        //Static variable to track the last assigned BookId
        private static int lastAssignedBookId = 0;
        public String BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        //public string Description { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        public Book()
        {
            //Auto-generate the BookId with "B" prefix
            BookId = "B" + ((++lastAssignedBookId).ToString());
        }

    }
}
