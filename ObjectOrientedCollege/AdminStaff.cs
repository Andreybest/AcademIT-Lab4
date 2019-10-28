namespace ObjectOrientedCollege
{
    public class AdminStaff : Employee
    {

        public AdminStaff(string firstName, string lastName, int age, string phoneNumber, int salary) : base(firstName, lastName, age, phoneNumber, salary) { }

        public Teacher Hire()
        {
            throw new System.NotImplementedException();
        }

        public Teacher Fire(Teacher teacher)
        {
            throw new System.NotImplementedException();
        }
    }
}