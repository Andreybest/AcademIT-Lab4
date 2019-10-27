using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class DepartmentHead : Teacher
    {
        private List<Teacher> subordinate = new List<Teacher>();

        public DepartmentHead(string firstName, string lastName, int age, string phoneNumber, int salary, int knowlageLevel, string subject) : base(firstName, lastName, age, phoneNumber, salary, knowlageLevel, subject) { }

        public void TrainSubordinates()
        {
            for (int i = 0; i < subordinate.Capacity; i++)
            {
                subordinate[i].KnowlageLevel++;
            }
        }
    }
}