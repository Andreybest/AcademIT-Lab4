using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Teacher : Employee
    {
        protected int practiceLevel;
        protected string subject;

        public Teacher(string firstName, string lastName, int age, string phoneNumber, int salary, int practiceLevel, string subject) : base(firstName, lastName, age, phoneNumber, salary)
        {
            this.practiceLevel = practiceLevel;
            this.subject = subject;
        }

        public void Teach(Student student)
        {
            throw new System.NotImplementedException();
        }
    }
}