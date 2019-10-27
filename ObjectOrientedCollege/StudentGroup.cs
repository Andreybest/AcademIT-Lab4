using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class StudentGroup
    {
        private List<Student> students = new List<Student>();
        public List<Student> Students { get => students; private set => students = value; }
        public readonly int groupNumber;

        public StudentGroup(int groupNumber)
        {
            this.groupNumber = groupNumber;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public override string ToString()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i] is Headman headman)
                {
                    return $"Group {groupNumber} students:\n" + headman.CreateGroupRaport(Students);
                }
            }
            return "This group dosen't have headman, please assign one in order to use this function.";
        }
    }
}