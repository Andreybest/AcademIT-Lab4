using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Student : Human, IMoneyGetting
    {
        Random rand = new Random();

        delegate void MoneyEarn();
        MoneyEarn EarnMoney;

        public readonly int group;
        protected int scholarship;
        public int Scholarship
        {
            get => scholarship;
            set => scholarship = Math.Max(minScholarship, value);
        }
        public const int minScholarship = 1000;
        protected int salary = 2500;

        protected int knowlageLevel;

        public int KnowlageLevel
        {
            get => knowlageLevel;
            set
            {
                if (Enum.IsDefined(typeof(EKnowlageLevel), value))
                {
                    if (value == (int)EKnowlageLevel.high)
                    {
                        EarnMoney = EarnJobMoney;
                    }
                    knowlageLevel = value;
                }
            }
        }
        
        private const float maxKnowlageProgress = 100;
        protected float knowlageProgress = 0;
        public float KnowlageProgress
        {
            get => knowlageProgress;
            set
            {
                if (value >= maxKnowlageProgress)
                {
                    knowlageProgress = 0;
                    KnowlageLevel++;
                }
                else
                {
                    knowlageProgress = value;
                }
            }
        }

        public Student(string firstName, string lastName, int age, string phoneNumber, int group, int scholarship = minScholarship, int knowlageLevel = (int)EKnowlageLevel.average) : base(firstName, lastName, age, phoneNumber)
        {
            EarnMoney = EarnScholarship;
            this.group = group;
            Scholarship = scholarship;
            KnowlageLevel = knowlageLevel;
        }

        private void EarnScholarship()
        {
            moneyAmount += scholarship;
            knowlageProgress += 5;
        }

        private void EarnJobMoney()
        {
            moneyAmount += salary;
            moneyAmount += scholarship;
            salary += 50;
        }

        public void MakeMoney()
        {
            EarnMoney();
        }

        private const int minSelfStudyResult = -2;
        private const int maxSelfStudyResult = 15;
        public void SelfStudy()
        {
            KnowlageProgress += rand.Next(minSelfStudyResult, maxSelfStudyResult);
        }

        public override string ToString()
        {
            return $"Name: {lastName} {firstName} Age: {age} Phone number: {phoneNumber}";
        }
    }
}