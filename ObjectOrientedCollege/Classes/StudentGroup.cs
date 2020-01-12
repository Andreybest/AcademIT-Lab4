using System.Collections.Generic;

namespace ObjectOrientedCollege
{
    public class StudentGroup
    {
        public List<Student> Students { get; private set; } = new List<Student>();
        public Headman GroupHeadman { get; private set; }

        public readonly int groupNumber;

        public StudentGroup(int groupNumber)
        {
            this.groupNumber = groupNumber;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public int FindStudent(string firstName, string lastName)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].firstName == firstName && Students[i].lastName == lastName)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
            if (student is Headman) RemoveHeadman();
        }

        public bool AddHeadman(Headman headman)
        {
            if (!GroupHeadmanExists())
            {
                GroupHeadman = headman;
                return true;
            }
            return false;
        }

        private void RemoveHeadman()
        {
            GroupHeadman = null;
        }

        public bool GroupHeadmanExists()
        {
            if (GroupHeadman != null)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Group {groupNumber} students:\n" + GroupHeadman.CreateGroupRaport(Students);
        }
    }
}