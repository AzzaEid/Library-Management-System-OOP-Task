namespace Library_Management_System____OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new MyLibrary();
            var staff = new LibraryStaff ("Ahmad","Nablus",4688885, "Auditor", library);
            var member1 = new Member ("Mohammed", "Ramallah", 0598765432,"M12345");
            var member2 = new Member("Ali", "Ramallah", 0598754997, "M12349");

            IBorrowable book1 = new Book("1", "The Pragmatic Programmer", "Andrew Hunt & David Thomas", 1999, 1.5m);
            IBorrowable book2 = new Book("2", "Clean Code", "Robert C. Martin", 2008, 2.0m);
            IBorrowable book3 = new Book("3", "Design Patterns: Elements of Reusable Object-Oriented Software", "Erich Gamma et al.", 1994, 2.5m);
            IBorrowable book4 = new Book("4", "Introduction to the Theory of Computation", "Michael Sipser", 2005, 1.8m);
            IBorrowable book5 = new Book("5", "Artificial Intelligence: A Modern Approach", "Stuart Russell & Peter Norvig", 2010, 3.0m);

            //*********//
            Console.WriteLine("Add Books by Staff\n");
            staff.AddBook((Book)book1);
            staff.AddBook((Book)book2);
            staff.AddBook((Book)book3);
            staff.AddBook((Book)book4);
            staff.AddBook((Book)book5);

            //*********//
            Console.WriteLine("\n\nAdd member by staff\n");
            staff.AddMember(member1);
            staff.AddMember(member2);


            //*********//
            Console.WriteLine("\n\nBorrow Book by member\n");
            member1.Borrow(book2, library);
            member2.Borrow(book1, library);
            member2.Borrow(book2, library);


            //*********//
            Console.WriteLine("\n\nReturn book by member\n");
            member1.Return(book2, library);
            member1.Return(book1, library);
            member2.Return(book1, library);

            //*********//
            Console.WriteLine("\n\nShow library statistics\n");
            library.ShowStatistics();

        }
    }
}
