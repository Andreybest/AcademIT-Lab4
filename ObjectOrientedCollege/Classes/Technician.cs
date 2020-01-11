namespace ObjectOrientedCollege
{
    public class Technician : Employee
    {
        private const int CleanAmount = 80;

        public int CleanTimes { get; private set; } = 0;

        public Technician(string firstName, string lastName, int age, string phoneNumber, int salary) : base(firstName, lastName, age, phoneNumber, salary) { }

        public void CleanAudince(Audience audience)
        {
            audience.Clearness += CleanAmount;
            CleanTimes++;
        }
    }
}