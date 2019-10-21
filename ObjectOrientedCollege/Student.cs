using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Student : Human, IMoneyGetting
    {

        public static int CountStudents = 0;

        protected int group;
        protected int scholarship;

        protected int knowlageLevel;
        protected int knowlageProgress;

        public Student(string firstName, string lastName, int age, string phoneNumber, int group, int knowlageLevel = 0) : base(firstName, lastName, age, phoneNumber)
        {
            this.group = group;
            this.knowlageLevel = knowlageLevel;

            CountStudents++;
        }

        public void MakeMoney()
        {

        }

        public void SelfStudy()
        {
            knowlageProgress += 10;
            knowlageLevel = (int)EKnowlageLevel.high;
        }

    }
}