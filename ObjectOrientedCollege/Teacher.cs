using System;

namespace ObjectOrientedCollege
{
    public class Teacher : Employee
    {
        Random rand = new Random();

        public readonly string subject;

        const float knowlagePerLesson = 15f;

        public Teacher(string firstName, string lastName, int age, string phoneNumber, int salary, string subject) : base(firstName, lastName, age, phoneNumber, salary)
        {
            this.subject = subject;
        }

        const int minRandomKnowlage = 1;
        const int maxRandomKnowlage = 3;
        public void TeachGroup(StudentGroup group, Audience audience)
        {
            for (int i = 0; i < group.Students.Count; i++)
            {
                group.Students[i].KnowlageProgress += knowlagePerLesson * (float)rand.Next(minRandomKnowlage, maxRandomKnowlage) * ((float)audience.Clearness / (float)Audience.maxClearness) * (1f / (float)group.Students.Count);
            }
            // Audience clearness decreased by 30 to imitate dirtyness after lesson.
            audience.Clearness -= 30;
        }
    }
}