﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class College
    {
        public readonly string name;
        public readonly string address;
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<StudentGroup> studentGroups = new List<StudentGroup>();
        private List<Audience> audiences = new List<Audience>();
        private List<Technician> technicians = new List<Technician>();

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

        public void AddTeacher(string firstName, string lastName, int age, string phoneNumber, int salary, int knowlageLevel, string subject)
        {
            Teacher teacher = new Teacher(firstName, lastName, age, phoneNumber, salary, knowlageLevel, subject);
            teachers.Add(teacher);
        }

        public void AddStudent(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = Student.minScholarship, int knowlageLevel = (int)EKnowlageLevel.average)
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

        public void AddTechnician(string firstName, string lastName, int age, string phoneNumber, int salary)
        {
            Technician technician = new Technician(firstName, lastName, age, phoneNumber, salary);
            technicians.Add(technician);
        }
    }
}