﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System____OOP
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Person(string name, string address, int phoneNumber)
        {
            Name = name;  
            Address = address;
            PhoneNumber = phoneNumber;

        }

    }
}
