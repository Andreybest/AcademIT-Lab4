using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public abstract class Employee : Human, IMoneyGetting
    {
        protected int salary;

        public Employee(string firstName, string lastName, int age, string phoneNumber, int salary) : base(firstName, lastName, age, phoneNumber)
        {
            this.salary = salary;
        }

        public void MakeMoney()
        {

        }
    }
}