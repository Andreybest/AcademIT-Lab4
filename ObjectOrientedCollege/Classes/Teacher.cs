using System;

namespace ObjectOrientedCollege
{
    public class Teacher : Employee
    {
        Random rand = new Random();

        public readonly string subject;

        private const float _knowlagePerLesson = 15f;

        public Teacher(string firstName, string lastName, int age, string phoneNumber, int salary, string subject) : base(firstName, lastName, age, phoneNumber, salary)
        {
            this.subject = subject;
        }

        private const int _minRandomKnowlage = 1;
        private const int _maxRandomKnowlage = 3;
        public void TeachGroup(StudentGroup group, Audience audience)
        {
            for (int i = 0; i < group.Students.Count; i++)
            {
                group.Students[i].KnowlageProgress += _knowlagePerLesson * (float)rand.Next(_minRandomKnowlage, _maxRandomKnowlage) * ((float)audience.Clearness / (float)Audience.maxClearness) * (1f / group.Students.Count);
            }
            // Audience clearness decreased by 30 to imitate dirtyness after lesson.
            audience.Clearness -= 30;
        }
    }
}