using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataModels
{
    public class BorrowedBook
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        /*public BorrowedBook(string bookId, string title, string author, string isbn) 
        {
            BookId = bookId;
            Title = title;
            Author = author;
            ISBN = isbn;
        }*/
    }
}
