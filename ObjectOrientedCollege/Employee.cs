﻿namespace ObjectOrientedCollege
{
    public abstract class Employee : Human, IMoneyGetting
    {
        public int salary;

        public Employee(string firstName, string lastName, int age, string phoneNumber, int salary) : base(firstName, lastName, age, phoneNumber)
        {
            this.salary = salary;
        }

        public void MakeMoney()
        {
            moneyAmount += salary;
        }
    }
}