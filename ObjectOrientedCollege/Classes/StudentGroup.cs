using System.Collections.Generic;

namespace ObjectOrientedCollege
{
    public class StudentGroup
    {
        private const string NoGroupHeadmanMessage = "This group dosen't have headman, please assign one in order to use this function.";

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

        public bool AddHeadman(Headman headman)
        {
            if (!GroupHeadmanExists())
            {
                GroupHeadman = headman;
                return true;
            }
            return false;
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
            if (GroupHeadmanExists())
            {
                return $"Group {groupNumber} students:\n" + GroupHeadman.CreateGroupRaport(Students);
            }
            return NoGroupHeadmanMessage;
        }
    }
}