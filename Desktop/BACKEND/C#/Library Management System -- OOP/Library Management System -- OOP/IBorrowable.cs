using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System____OOP
{
    internal interface IBorrowable
    {
        void Borrow(Member member);
        decimal Return();
    }
}
