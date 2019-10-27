using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Technician : Employee
    {
        const int cleanAmount = 80;

        public Technician(string firstName, string lastName, int age, string phoneNumber, int salary) : base(firstName, lastName, age, phoneNumber, salary) { }

        public void CleanAudince(Audience audience)
        {
            audience.Clearness += cleanAmount;
        }
    }
}