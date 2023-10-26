using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataModels
{
    public class Member
    {
        //Static variable to track the last assigned LibrairanId
        private static int lastAssignedMemberId = 0;
        public string MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Member()
        {
            //Auto-generate the MemberId with "M" prefix
            MemberId = "M" + ((++lastAssignedMemberId).ToString());
        }


    }
}
