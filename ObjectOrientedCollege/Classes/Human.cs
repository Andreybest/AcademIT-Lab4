namespace ObjectOrientedCollege
{
    public abstract class Human : IMoneyGetting
    {
        public readonly string FirstName;
        public readonly string LastName;
        public readonly int Age;
        public readonly string PhoneNumber;
        public int MoneyAmount = 0;

        public Human(string firstName, string lastName, int age, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
        }

        public void MakeMoney() {}
    }
}