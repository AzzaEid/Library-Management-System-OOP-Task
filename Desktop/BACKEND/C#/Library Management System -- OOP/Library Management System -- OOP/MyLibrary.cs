using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System____OOP
{
    internal class MyLibrary : Library
    {

        public override void AddBook(IBorrowable book)
        {
            if(book == null) return;

            bool exists = books.Any(b => b is Book bk && bk.BookID == ((Book)book).BookID);
            if (exists)
            {
                Console.WriteLine("The book is already exist!");
                return;
            }

            books.Add(book);
            Console.WriteLine($"Book '{((Book)book).Title}' added to the library.");
        }

        public override void RemoveBook(int bookID)
        {
            var book= books.FirstOrDefault(b => b is Book bk && bk.BookID == bookID);
            if (book != null )
            {
                books.Remove(book);
                Console.WriteLine("Book removed.");
            }
            
        }

        public override void AddMember(Member member)
        {
            if (member == null) return;

            if (members.Contains(member))
            {
                Console.WriteLine("The member id already added ");
                return;
            }

            members.Add(member);
            Console.WriteLine($"Member {member.Name} added to library");
        }
        public override void RemoveMember(Member member)
        {
            members.Remove(member);
            Console.WriteLine("Member removed");

            //in future we have to return fees
        }

        public override bool Borrow(Member member, IBorrowable borrowable)
        {

            //Check if this member is member in the library
            if (!members.Contains(member))
            {
                Console.WriteLine("Member is not in the Library System");
                return false;
            }

            //Check if borrowable is a book is in the library
            if (borrowable is Book book) {
                return BorrowBook(member, book);
            }
            return false;

        }
        private bool BorrowBook(Member member, Book book)
        {
            //Check the book in the library 
            if (!books.Contains(book))
            {
                Console.WriteLine("Book is not in the Library System");
                return false;
            }

            //Check if book is available to borrow
            if (!book.IsAvailable) {
                Console.WriteLine($"={book.Title}= Is not aviable");
                return false;
            }
            book.IsAvailable = false;
            book.Borrow(member);
            return true;
        }

        public override decimal Return(Member member, IBorrowable borrowable)
        {
            //Check if this member is member in the library
            if (!members.Contains(member))
            {
                Console.WriteLine("Member is not in the Library System.");
                return -1;
            }

            //Check if borrowable is a book is in the library
            if (borrowable is Book book)
            {
                if(member != book.CurrentBorrower)
                {
                    Console.WriteLine("U cannot Return book u don't have.");
                    return -1;
                }
                return ReturnBook(book);
            }
            return -1;
        }

        private decimal ReturnBook(Book book)
        {
            //Check the book in the library 
            if (!books.Contains(book))
            {
                Console.WriteLine("Book is not in the Library System.");
                return -1;
            }

            book.IsAvailable = true;

            return book.Return();
        }

        public int BorrowedBooksCount => books.Count(b => b is Book bk && !bk.IsAvailable);
        public int OverdueBooksCount => books.Count(b => b is Book bk && !bk.IsAvailable && bk.DueToDate < DateTime.Now);

        public override void ShowStatistics()
        {
            Console.WriteLine($"All Books:\t{books.Count} " +
                $"\nAll Members:\t{members.Count}" +
                $"\nBorrowed Books:\t{BorrowedBooksCount}" +
                $"\nOverdue Books:\t{OverdueBooksCount}");
        }

        public override Book SearchForBook(string word)
        {
            //Another alternative way to casting
            var book = books.OfType<Book>().FirstOrDefault(b => b.Title.Contains(word) || b.Auther.Contains(word));

            return book ?? null;

        }
    }
}
