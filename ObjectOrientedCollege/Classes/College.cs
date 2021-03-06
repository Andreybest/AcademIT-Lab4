﻿using System.Collections.Generic;

namespace ObjectOrientedCollege
{
    public class College
    {
        public readonly string Name;
        public readonly string Address;
        public List<Student> Students = new List<Student>();
        public List<Teacher> Teachers = new List<Teacher>();
        public List<StudentGroup> StudentGroups = new List<StudentGroup>();
        public List<Audience> Audiences = new List<Audience>();
        public List<Technician> Technicians = new List<Technician>();

        public College(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public void AddAudience(int roomNumber, int clearness = 100)
        {
            if (FindAudienceIndex(roomNumber) != -1)
            {
                throw new ExistingNumerationException();
            }

            Audience audience = new Audience(roomNumber, clearness);
            Audiences.Add(audience);
        }

        private int FindAudienceIndex(int roomNumber)
        {
            for (int i = 0; i < Audiences.Count; i++)
            {
                if (Audiences[i].RoomNumber == roomNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        public Audience FindAudience(int roomNumber)
        {
            int audienceIndex = FindAudienceIndex(roomNumber);
            if (audienceIndex != -1)
            {
                return Audiences[audienceIndex];
            }
            return null;
        }

        public void RemoveAudience(Audience audience)
        {
            Audiences.Remove(audience);
        }

        public void AddGroup(int groupNumber)
        {
            if (FindGroupIndex(groupNumber) != -1)
            {
                throw new ExistingNumerationException();
            }

            StudentGroup studentGroup = new StudentGroup(groupNumber);
            StudentGroups.Add(studentGroup);
        }

        private int FindGroupIndex(int groupNumber)
        {
            for (int i = 0; i < StudentGroups.Count; i++)
            {
                if (StudentGroups[i].GroupNumber == groupNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        public StudentGroup FindGroup(int groupNumber)
        {
            int groupIndex = FindGroupIndex(groupNumber);
            if (groupIndex != -1)
            {
                return StudentGroups[groupIndex];
            }
            return null;
        }

        public void RemoveGroup(StudentGroup group)
        {
            StudentGroups.Remove(group);
        }

        public void AddTeacher(string firstName, string lastName, int age, string phoneNumber, int salary, string subject)
        {
            if (FindTeacherIndex(firstName, lastName) != -1)
            {
                throw new ExistingFullNameException();
            }
            Teacher teacher = new Teacher(firstName, lastName, age, phoneNumber, salary, subject);
            Teachers.Add(teacher);
        }

        private int FindTeacherIndex(string firstName, string lastName)
        {
            for (int i = 0; i < Teachers.Count; i++)
            {
                if (Teachers[i].FirstName == firstName && Teachers[i].LastName == lastName)
                {
                    return i;
                }
            }
            return -1;
        }

        public Teacher FindTeacher(string firstName, string lastName)
        {
            int teacherIndex = FindTeacherIndex(firstName, lastName);
            if (teacherIndex != -1)
            {
                return Teachers[teacherIndex];
            }
            return null;
        }

        public void RemoveTeacher(Teacher teacher)
        {
            Teachers.Remove(teacher);
        }

        public void AddStudent(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = Student.MinScholarship, int knowlageLevel = (int)EKnowlageLevel.average)
        {
            int groupIndex = FindGroupIndex(group);
            if (groupIndex == -1)
            {
                throw new NonExistingGroupException();
            }

            if (FindStudentIndex(firstName, lastName) != -1)
            {
                throw new ExistingFullNameException();
            }

            Student student = new Student(firstName, lastName, age, phoneNumber, group, scholarship, knowlageLevel);
            StudentGroups[groupIndex].AddStudent(student);
            Students.Add(student);
        }

        private int FindStudentIndex(string firstName, string lastName)
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

        public Student FindStudent(string firstName, string lastName)
        {
            int studentIndex = FindStudentIndex(firstName, lastName);
            if (studentIndex != -1)
            {
                return Students[studentIndex];
            }
            return null;
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void AddHeadman(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = Headman.MinScholarship, int knowlageLevel = (int)EKnowlageLevel.average)
        {
            int groupIndex = FindGroupIndex(group);
            if (groupIndex == -1)
            {
                throw new NonExistingGroupException();
            }

            if (FindStudentIndex(firstName, lastName) != -1)
            {
                throw new ExistingFullNameException();
            }

            if (StudentGroups[groupIndex].GroupHeadmanExists())
            {
                throw new GroupHeadmanAlreadyExistException();
            }

            Headman headman = new Headman(firstName, lastName, age, phoneNumber, group, scholarship, knowlageLevel);
            StudentGroups[groupIndex].AddStudent(headman);
            StudentGroups[groupIndex].AddHeadman(headman);
            Students.Add(headman);
        }

        public void AddTechnician(string firstName, string lastName, int age, string phoneNumber, int salary)
        {
            if (FindTechnicianIndex(firstName, lastName) != -1)
            {
                throw new ExistingFullNameException();
            }

            Technician technician = new Technician(firstName, lastName, age, phoneNumber, salary);
            Technicians.Add(technician);
        }

        private int FindTechnicianIndex(string firstName, string lastName)
        {
            for (int i = 0; i < Technicians.Count; i++)
            {
                if (Technicians[i].FirstName == firstName && Technicians[i].LastName == lastName)
                {
                    return i;
                }
            }
            return -1;
        }

        public Technician FindTechnician(string firstName, string lastName)
        {
            int technicianIndex = FindTechnicianIndex(firstName, lastName);
            if (technicianIndex != -1)
            {
                return Technicians[technicianIndex];
            }
            return null;
        }

        public void RemoveTechnician(Technician technician)
        {
            Technicians.Remove(technician);
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
            GiveMoneyToEveryHumanInList(Students);
            GiveMoneyToEveryHumanInList(Teachers);
            GiveMoneyToEveryHumanInList(Technicians);
        }
    }
}