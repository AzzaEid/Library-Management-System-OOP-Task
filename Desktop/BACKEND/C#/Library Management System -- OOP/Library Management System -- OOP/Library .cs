using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System____OOP
{
    internal abstract class Library
    {
        public List<IBorrowable> books = new List<IBorrowable>();
        public List<Member> members = new List<Member>();

        public abstract void AddBook (IBorrowable book);
        public abstract void RemoveBook(int bookID);
        public abstract void AddMember(Member member);
        public abstract void RemoveMember(Member member);

        public abstract bool Borrow(Member member, IBorrowable borrowable);
        public abstract decimal Return(Member member, IBorrowable borrowable);

        public abstract void ShowStatistics();
        public abstract Book SearchForBook(string word);

    }
}
