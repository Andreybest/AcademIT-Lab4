using System;

namespace ObjectOrientedCollege
{
    public class Teacher : Employee
    {
        private const float KnowlagePerLesson = 15f;

        Random rand = new Random();

        public readonly string Subject;

        public Teacher(string firstName, string lastName, int age, string phoneNumber, int salary, string subject) : base(firstName, lastName, age, phoneNumber, salary)
        {
            this.Subject = subject;
        }

        private const int _minRandomKnowlage = 1;
        private const int _maxRandomKnowlage = 3;
        public void TeachGroup(StudentGroup group, Audience audience)
        {
            for (int i = 0; i < group.Students.Count; i++)
            {
                group.Students[i].KnowlageProgress += KnowlagePerLesson * (float)rand.Next(_minRandomKnowlage, _maxRandomKnowlage) * ((float)audience.Clearness / (float)Audience.MaxClearness) * (1f / group.Students.Count);
            }
            // Audience clearness decreased by 30 to imitate dirtyness after lesson.
            audience.Clearness -= 30;
        }
    }
}