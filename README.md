# Library-Management-System

#### Description: 📔

You are tasked with developing a simple Library Management System using Object-Oriented Programming (OOP) concepts in C#. The system will manage books, members, and staff in a library. Your task is to create classes that reflect real-world entities and implement necessary functionalities. The system should use key OOP principles such as inheritance, polymorphism, and abstraction.
*********
#### Requirements: 📌

**Basic Object Types (Classes):**

📚**Book:** A class to represent a book, which should have properties like: Title (string) Author (string) Publication Year (int) Book ID (string)

👨🏻**Member:** A class to represent a library member with properties like: Member Name (string) Membership ID (string) Join Date (DateTime)

👨🏻‍🏫**LibraryStaff:** A class to represent a library staff member with properties such as: Staff Name (string) Job Title (string) Hire Date (DateTime)
*******
#### System Functions:⚙️

1- Add Book: Staff members should be able to add new books to the library.

2- Borrow Book: Members can borrow books for a period of 14 days.

3- Return Book: Members can return books once the borrowing period is complete.

4- Create a base class Person containing properties common to both Member and LibraryStaff, such as Name, Address, and Phone Number. Both Member and LibraryStaff should inherit from Person.

5- Create an interface IBorrowable that contains methods for borrowing and returning books. The Book class should implement this interface, and polymorphism should be used to dynamically call the borrowing and returning methods.

6- Create an abstract class Library that contains a list of books and members. It should also have abstract methods like AddMember(), AddBook(), and BorrowBook(), which will be implemented in derived classes.
******
#### Advanced Features:🎯

1-Late Fees: Implement logic to calculate a late fee if a book is not returned on time (overdue books). 2-Statistics: Implement functionality to show statistics such as the number of books currently borrowed and the number of overdue books. 3-Search Books: Add a method to search for books by title or author.
