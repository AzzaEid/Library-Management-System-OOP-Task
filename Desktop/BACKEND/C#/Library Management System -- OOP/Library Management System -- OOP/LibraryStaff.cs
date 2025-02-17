using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System____OOP
{
    internal class LibraryStaff : Person
    {
        public Guid StaffID { get; private set; }  
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; } = DateTime.Now;
        public Library MyLibrary { get; set; }

        public LibraryStaff(string name , string address, int phoneNumber, string jobTitle, Library library)
            : base(name, address, phoneNumber)
        {
            StaffID = Guid.NewGuid();
            JobTitle = jobTitle;
            MyLibrary = library;
        }

        public void AddBook(Book book)
        {
            MyLibrary.AddBook(book);
        }

       public void AddMember(Member member)
       {
            MyLibrary.AddMember(member);
       }

    }
}
