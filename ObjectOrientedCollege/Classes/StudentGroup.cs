using System.Collections.Generic;

namespace ObjectOrientedCollege
{
    public class StudentGroup
    {
        public List<Student> Students { get; private set; } = new List<Student>();
        public Headman GroupHeadman { get; private set; }

        public readonly int GroupNumber;

        public StudentGroup(int groupNumber)
        {
            this.GroupNumber = groupNumber;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public int FindStudent(string firstName, string lastName)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].FirstName == firstName && Students[i].LastName == lastName)
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

        public bool HasStudents()
        {
            if (Students.Count < 1) return false;
            return true;
        }

        public override string ToString()
        {
            return $"Group {GroupNumber} students:\n" + GroupHeadman.CreateGroupRaport(Students);
        }
    }
}