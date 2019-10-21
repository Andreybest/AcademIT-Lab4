using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Technician : Employee
    {

        public Technician(string firstName, string lastName, int age, string phoneNumber, int salary) : base(firstName, lastName, age, phoneNumber, salary) { }

        public void CleanAudince(Audience audience)
        {
            throw new System.NotImplementedException();
        }
    }
}