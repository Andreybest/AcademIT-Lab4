using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Headman : Student
    {

        public static int CountHeadmans = 0;

        public Headman(string firstName, string lastName, int age, string phoneNumber, int group, int knowlageLevel) : base(firstName, lastName, age, phoneNumber, group, knowlageLevel)
        {
            CountHeadmans++;
        }

        public void CreateRaport()
        {
            throw new System.NotImplementedException();
        }
    }
}