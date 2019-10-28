using System.Collections.Generic;

namespace ObjectOrientedCollege
{
    public class StudentGroup
    {
        private List<Student> students = new List<Student>();
        public List<Student> Students { get => students; private set => students = value; }
        private Headman groupHeadman;
        public Headman GroupHeadman { get => groupHeadman; private set => groupHeadman = value; }

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
                groupHeadman = headman;
                return true;
            }
            return false;
        }

        public bool GroupHeadmanExists()
        {
            if (groupHeadman != null)
            {
                return true;
            }
            return false;
        }

        public const string noGroupHeadman = "This group dosen't have headman, please assign one in order to use this function.";
        public override string ToString()
        {
            if (GroupHeadmanExists())
            {
                return $"Group {groupNumber} students:\n" + groupHeadman.CreateGroupRaport(Students);
            }
            return noGroupHeadman;
        }
    }
}