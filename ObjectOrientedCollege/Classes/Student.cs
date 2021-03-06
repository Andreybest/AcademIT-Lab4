﻿using System;

namespace ObjectOrientedCollege
{
    public class Student : Human, IMoneyGetting
    {
        public const int MinScholarship = 1000;

        Random rand = new Random();

        delegate void MoneyEarn();
        MoneyEarn EarnMoney;

        public readonly int Group;
        protected int _scholarship;
        public int Scholarship
        {
            get => _scholarship;
            set => _scholarship = Math.Max(MinScholarship, value);
        }
        protected int _salary = 2500;

        protected int _knowlageLevel;

        public int KnowlageLevel
        {
            get => _knowlageLevel;
            set
            {
                if (Enum.IsDefined(typeof(EKnowlageLevel), value))
                {
                    if (value == (int)EKnowlageLevel.high)
                    {
                        EarnMoney = EarnJobMoney;
                    }
                    _knowlageLevel = value;
                }
            }
        }
        
        private const float _maxKnowlageProgress = 100;
        protected float _knowlageProgress = 0;
        public float KnowlageProgress
        {
            get => _knowlageProgress;
            set
            {
                if (value >= _maxKnowlageProgress)
                {
                    _knowlageProgress = 0;
                    KnowlageLevel++;
                }
                else
                {
                    _knowlageProgress = value;
                }
            }
        }

        public Student(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = MinScholarship, int knowlageLevel = (int)EKnowlageLevel.average) : base(firstName, lastName, age, phoneNumber)
        {
            EarnMoney = EarnScholarship;
            this.Group = group;
            Scholarship = scholarship;
            KnowlageLevel = knowlageLevel;
        }

        private void EarnScholarship()
        {
            MoneyAmount += _scholarship;
            _knowlageProgress += 5;
        }

        private void EarnJobMoney()
        {
            MoneyAmount += _salary;
            MoneyAmount += _scholarship;
            _salary += 50;
        }

        public void MakeMoney()
        {
            EarnMoney();
        }

        private const int _minSelfStudyResult = -2;
        private const int _maxSelfStudyResult = 15;
        public void SelfStudy()
        {
            KnowlageProgress += rand.Next(_minSelfStudyResult, _maxSelfStudyResult);
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Age: {Age} Phone number: {PhoneNumber}";
        }
    }
}