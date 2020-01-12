using System.Collections.Generic;

namespace ObjectOrientedCollege
{
    public class College
    {
        public readonly string name;
        public readonly string address;
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();
        public List<StudentGroup> studentGroups = new List<StudentGroup>();
        public List<Audience> audiences = new List<Audience>();
        public List<Technician> technicians = new List<Technician>();

        public College(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void AddAudience(int roomNumber, int clearness = 100)
        {
            if (FindAudience(roomNumber) != -1)
            {
                throw new ExistingNumerationException();
            }

            Audience audience = new Audience(roomNumber, clearness);
            audiences.Add(audience);
        }

        public int FindAudience(int roomNumber)
        {
            for (int i = 0; i < audiences.Count; i++)
            {
                if (audiences[i].roomNumber == roomNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAudience(Audience audience)
        {
            audiences.Remove(audience);
        }

        public void AddGroup(int groupNumber)
        {
            if (FindGroup(groupNumber) != -1)
            {
                throw new ExistingNumerationException();
            }

            StudentGroup studentGroup = new StudentGroup(groupNumber);
            studentGroups.Add(studentGroup);
        }

        public int FindGroup(int groupNumber)
        {
            for (int i = 0; i < studentGroups.Count; i++)
            {
                if (studentGroups[i].groupNumber == groupNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveGroup(StudentGroup group)
        {
            studentGroups.Remove(group);
        }

        public void AddTeacher(string firstName, string lastName, int age, string phoneNumber, int salary, string subject)
        {
            if (FindTeacher(firstName, lastName) != -1)
            {
                throw new ExistingFullNameException();
            }
            Teacher teacher = new Teacher(firstName, lastName, age, phoneNumber, salary, subject);
            teachers.Add(teacher);
        }

        public int FindTeacher(string firstName, string lastName)
        {
            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i].firstName == firstName && teachers[i].lastName == lastName)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public void AddStudent(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = Student.MinScholarship, int knowlageLevel = (int)EKnowlageLevel.average)
        {
            int groupIndex = FindGroup(group);
            if (groupIndex == -1)
            {
                throw new NonExistingGroupException();
            }

            if (FindStudent(firstName, lastName) != -1)
            {
                throw new ExistingFullNameException();
            }

            Student student = new Student(firstName, lastName, age, phoneNumber, group, scholarship, knowlageLevel);
            studentGroups[groupIndex].AddStudent(student);
            students.Add(student);
        }

        public int FindStudent(string firstName, string lastName)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].firstName == firstName && students[i].lastName == lastName)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void AddHeadman(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = Headman.MinScholarship, int knowlageLevel = (int)EKnowlageLevel.average)
        {
            int groupIndex = FindGroup(group);
            if (groupIndex == -1)
            {
                throw new NonExistingGroupException();
            }

            if (FindStudent(firstName, lastName) != -1)
            {
                throw new ExistingFullNameException();
            }

            if (studentGroups[groupIndex].GroupHeadmanExists())
            {
                throw new GroupHeadmanAlreadyExistException();
            }

            Headman headman = new Headman(firstName, lastName, age, phoneNumber, group, scholarship, knowlageLevel);
            studentGroups[groupIndex].AddStudent(headman);
            studentGroups[groupIndex].AddHeadman(headman);
            students.Add(headman);
        }

        public void AddTechnician(string firstName, string lastName, int age, string phoneNumber, int salary)
        {
            if (FindTechnician(firstName, lastName) != -1)
            {
                throw new ExistingFullNameException();
            }

            Technician technician = new Technician(firstName, lastName, age, phoneNumber, salary);
            technicians.Add(technician);
        }

        public int FindTechnician(string firstName, string lastName)
        {
            for (int i = 0; i < technicians.Count; i++)
            {
                if (technicians[i].firstName == firstName && technicians[i].lastName == lastName)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveTechnician(Technician technician)
        {
            technicians.Remove(technician);
        }

        private void GiveMoneyToEveryHumanInList<T>(List<T> humans) where T : IMoneyGetting
        {
            for (int i = 0; i < humans.Count; i++)
            {
                humans[i].MakeMoney();
            }
        }

        public void GiveMoneyToEveryHuman()
        {
            GiveMoneyToEveryHumanInList(students);
            GiveMoneyToEveryHumanInList(teachers);
            GiveMoneyToEveryHumanInList(technicians);
        }
    }
}