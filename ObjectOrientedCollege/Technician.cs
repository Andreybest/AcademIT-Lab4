namespace ObjectOrientedCollege
{
    public class Technician : Employee
    {
        const int cleanAmount = 80;

        private int cleanTimes = 0;
        public int CleanTimes { get => cleanTimes; private set => cleanTimes = value; }

        public Technician(string firstName, string lastName, int age, string phoneNumber, int salary) : base(firstName, lastName, age, phoneNumber, salary) { }

        public void CleanAudince(Audience audience)
        {
            audience.Clearness += cleanAmount;
            CleanTimes++;
        }
    }
}