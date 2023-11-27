namespace ConsoleApp1
{
    internal class Employee
    {
        private readonly string firstName;
        private readonly string lastName;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FullName() => $"Full Name = {this.firstName} {this.lastName}";
    }
}
