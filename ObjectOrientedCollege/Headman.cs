using System.Collections.Generic;

namespace ObjectOrientedCollege
{
    public class Headman : Student
    {
        public int CountHeadmans { get; private set; } = 0;

        public new const int minScholarship = 1500;

        public Headman(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = minScholarship, int knowlageLevel = (int)EKnowlageLevel.average) : base(firstName, lastName, age, phoneNumber, group, scholarship, knowlageLevel)
        {
            CountHeadmans++;
        }

        public string CreateGroupRaport(List<Student> students)
        {
            string studentsInfo = "";
            for (int i = 0; i < students.Count; i++)
            {
                studentsInfo += $"{students[i].ToString()}\n";
            }
            return studentsInfo;
        }
    }
}