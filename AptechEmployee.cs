namespace Exercise3
{
    internal class AptechEmployee : Employee, IEmployee
    {
        private bool IsTeacher { get; set; }
        private double Bounes { get; set; }

        public AptechEmployee()
        {
        }

        public AptechEmployee(bool isTeacher, double bounes) : base()
        {
            IsTeacher = isTeacher;
            Bounes = bounes;
        }

        public override double CalculateSalaryForMonth()
        {
            return (SalaryMonth / 30 * TotalDayInWorks) + Bounes;
        }

        public override void Display()
        {
            base.Display();


        }

        public override void Input()
        {
            base.Input();

            Console.WriteLine("You are a teacher: ");
            this.IsTeacher = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter employee bounus: ");
            this.Bounes = Convert.ToDouble(Console.ReadLine());
        }
    }
}
