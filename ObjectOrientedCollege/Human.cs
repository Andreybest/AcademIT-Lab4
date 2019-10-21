using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public abstract class Human
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected string phoneNumber;
        protected int moneyAmount = 0;

        public Human(string firstName, string lastName, int age, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.phoneNumber = phoneNumber;
        }
    }
}