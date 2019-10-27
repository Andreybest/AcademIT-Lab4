using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Teacher : Employee
    {
        Random rand = new Random();

        protected int knowlageLevel;
        public int KnowlageLevel
        {
            get => knowlageLevel;
            set
            {
                if (Enum.IsDefined(typeof(EKnowlageLevel), value))
                {
                    knowlageLevel = value;
                }
            }
        }
        public readonly string subject;

        const int knowlagePerLesson = 5;

        public Teacher(string firstName, string lastName, int age, string phoneNumber, int salary, int knowlageLevel, string subject) : base(firstName, lastName, age, phoneNumber, salary)
        {
            KnowlageLevel = knowlageLevel;
            this.subject = subject;
        }

        const int minRandomKnowlage = 0;
        const int maxRandomKnowlage = 3;
        public void TeachGroup(List<Student> students, Audience audience)
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].KnowlageProgress += knowlagePerLesson * KnowlageLevel * rand.Next(minRandomKnowlage, maxRandomKnowlage) * (audience.Clearness / Audience.maxClearness);
            }
            audience.Clearness -= 30;
        }
    }
}