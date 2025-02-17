using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System____OOP
{
    internal class Member : Person
    {
        public Guid MemberID { get; private set;}
        public DateTime JoinDate { get; set; } = DateTime.Now;
        public string MembershipID { get; set; }

        public Member(string name, string address, int phoneNumber, string membershipID) 
            : base(name, address, phoneNumber)
        {
            MemberID = Guid.NewGuid();
            MembershipID = membershipID;
        }

        public bool Borrow(IBorrowable borrowable, Library library)
        {
            return library.Borrow(this, borrowable);
        }

        public decimal Return(IBorrowable borrowable, Library library)
        {
            return library.Return(this, borrowable);
        }


    }
}
