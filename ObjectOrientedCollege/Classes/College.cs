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
            for (int i = 0; i < audiences.Count; i++)
            {
                if (audiences[i].roomNumber == roomNumber)
                {
                    throw new ExistingNumerationException();
                }
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
            for (int i = 0; i < studentGroups.Count; i++)
            {
                if (studentGroups[i].groupNumber == groupNumber)
                {
                    throw new ExistingNumerationException();
                }
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
            for (int i = 0; i < studentGroups.Count; i++)
            {
                if (studentGroups[i].groupNumber == group)
                {
                    Student student = new Student(firstName, lastName, age, phoneNumber, group, scholarship, knowlageLevel);
                    studentGroups[i].AddStudent(student);
                    students.Add(student);
                    break;
                }
            }
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

        public bool AddHeadman(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = Headman.MinScholarship, int knowlageLevel = (int)EKnowlageLevel.average)
        {
            for (int i = 0; i < studentGroups.Count; i++)
            {
                if (studentGroups[i].groupNumber == group)
                {
                    if (!studentGroups[i].GroupHeadmanExists())
                    {
                        Headman headman = new Headman(firstName, lastName, age, phoneNumber, group, scholarship, knowlageLevel);
                        studentGroups[i].AddStudent(headman);
                        students.Add(headman);
                        studentGroups[i].AddHeadman(headman);
                        return true;
                    }
                }
            }
            return false;
        }

        public void AddTechnician(string firstName, string lastName, int age, string phoneNumber, int salary)
        {
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

        public void GiveMoneyToEveryHuman()
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].MakeMoney();
            }
            for (int i = 0; i < teachers.Count; i++)
            {
                teachers[i].MakeMoney();
            }
            for (int i = 0; i < technicians.Count; i++)
            {
                technicians[i].MakeMoney();
            }
        }
    }
}