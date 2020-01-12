﻿namespace ObjectOrientedCollege
{
    public abstract class Human : IMoneyGetting
    {
        public readonly string firstName;
        public readonly string lastName;
        public readonly int age;
        public readonly string phoneNumber;
        public int moneyAmount = 0;

        public Human(string firstName, string lastName, int age, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.phoneNumber = phoneNumber;
        }

        public void MakeMoney() {}
    }
}