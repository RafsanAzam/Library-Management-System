using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataModels
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool isFullfilled { get; set; }
    }
}
