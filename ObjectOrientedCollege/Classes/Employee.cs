namespace ObjectOrientedCollege
{
    public abstract class Employee : Human, IMoneyGetting
    {
        public int Salary;

        public Employee(string firstName, string lastName, int age, string phoneNumber, int salary) : base(firstName, lastName, age, phoneNumber)
        {
            this.Salary = salary;
        }

        public void MakeMoney()
        {
            MoneyAmount += Salary;
        }
    }
}