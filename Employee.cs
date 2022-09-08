namespace Exercise3
{
    internal class Employee : IEmployee
    {
        private string empId;
        private string fullName;
        private bool gender;
        private DateOnly birthday;
        private string address;
        private double salaryMonth;
        private int totalDayInWorks;

        public Employee()
        {
        }

        public Employee(string empId, string fullName, bool gender, DateOnly birthday, string address, double salaryMonth, int totalDayInWorks)
        {
            this.empId = empId;
            this.fullName = fullName;
            this.gender = gender;
            this.birthday = birthday;
            this.address = address;
            this.salaryMonth = salaryMonth;
            this.totalDayInWorks = totalDayInWorks;
        }

        public string EmpId { get => empId; set => empId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateOnly Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public double SalaryMonth { get => salaryMonth; set => salaryMonth = value; }
        public int TotalDayInWorks { get => totalDayInWorks; set => totalDayInWorks = value; }

        public virtual double CalculateSalaryForMonth()
        {
            return salaryMonth / 30 * totalDayInWorks;
        }

        public virtual void Display()
        {
            Console.WriteLine("ID: {0}", this.empId);
            Console.WriteLine("Name: {0}", this.fullName);
            Console.WriteLine("Gender: {0}", this.gender);
            Console.WriteLine("Address: {0}", this.address);
            Console.WriteLine("Birthday: {0}", this.birthday);
            Console.WriteLine("Salary Range: {0}", this.salaryMonth);
            Console.WriteLine("Total Working Days: {0}", this.totalDayInWorks);
            Console.WriteLine("Salary This Month: {0}", this.CalculateSalaryForMonth());
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter employee ID: ");
            this.empId = Console.ReadLine();

            Console.WriteLine("Enter employee name: ");
            this.fullName = Console.ReadLine();

            Console.WriteLine("Enter employee gender: ");
            this.gender = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Enter employee birthday: ");
            this.Birthday = DateOnly.Parse(Console.ReadLine());


            Console.WriteLine("Enter employee address: ");
            this.address = Console.ReadLine();

            Console.WriteLine("Enter employee salary: ");
            this.salaryMonth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter employee working day: ");
            this.totalDayInWorks = Convert.ToInt16(Console.ReadLine());

        }
    }
}
