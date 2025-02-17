using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System____OOP
{
    internal class Book : IBorrowable
    {
        public string BookID { get; set; }
        public string Title { get; set; } 
        public string Auther { get; set; }
        public int PublicationYear {  get; set; }

        #region Borrow/Return logic properties
        public bool IsAvailable { get; set; }
        public DateTime DueToDate {  get; private set; }
        public Member? CurrentBorrower { get; private set; }
        public decimal FeesForADay {  get; set; }
        #endregion
        

        public Book(string bookID, string title, string auther, int publicationYear, decimal feesForADay)
        {
            BookID = bookID;
            Title = title;
            Auther = auther;
            PublicationYear = publicationYear;
            IsAvailable = true;
            FeesForADay = feesForADay;
        }

        public void Borrow(Member member)
        {
            CurrentBorrower=member;
            DueToDate = DateTime.Now.AddDays(14);
            Console.WriteLine($"={Title}= has been borrowed. Due date: {DueToDate.ToShortDateString()}");
        }

        public decimal Return()
        {
            CurrentBorrower = null;
            //Calculate late days and fees
            int LateDays = (DateTime.Now - DueToDate).Days;
            LateDays = LateDays > 0 ? LateDays : 0;
            decimal totalFees = FeesForADay * LateDays;

            Console.WriteLine($"Totale Fees for late {LateDays} days is {totalFees}");
            return totalFees;
            // we need to add functionality to store fees for member 
        }
    }
}
