using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class DepartmentHead : Teacher
    {
        private List<Teacher> subordinate;

        public DepartmentHead(string firstName, string lastName, int age, string phoneNumber, int salary, int practiceLevel, string subject) : base(firstName, lastName, age, phoneNumber, salary, practiceLevel, subject) { }

        public void TrainTeachers(List<Teacher> teachers)
        {
            throw new System.NotImplementedException();
        }
    }
}