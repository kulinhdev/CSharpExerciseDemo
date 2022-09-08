namespace Exercise3
{
    class Program
    {

        private static List<Employee> employees = new List<Employee>() { };

        public static void Menu()
        {
            Console.WriteLine("\n+++ EMPLOYEES MANAGERMENT +++");
            Console.WriteLine("1. Enter employees: ");
            Console.WriteLine("2. Display employees: ");
            Console.WriteLine("3. Sort employee by salary: ");
            Console.WriteLine("4. Search employee : ");
            Console.WriteLine("5. Exit : ");
        }

        public static int EnterOption()
        {
            Menu();

            Console.WriteLine("\nEnter your chooose:");

            int enterOption = Convert.ToInt32(Console.ReadLine());

            return enterOption;
        }

        public static void EnterEmployees()
        {
            Console.WriteLine("\nEnter num of employees");

            int enteredEmp = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < enteredEmp; i++)
            {
                Console.WriteLine("\nPlease enter infomation employee {0}:", i + 1);

                Employee aptechEmp = new AptechEmployee();

                aptechEmp.Input();

                employees.Add(aptechEmp);
            }
        }

        public static void DisplayEmployees(List<Employee> ListEmps)
        {
            foreach (var employee in ListEmps)
            {
                Console.WriteLine("\n=== Employee Infomation ===");

                employee.Display();
            }
        }

        public static void SoftEmployeesBySalary()
        {
            List<Employee> sortedEmps = employees.OrderBy(e => e.SalaryMonth > e.SalaryMonth).ToList();

            if (sortedEmps.Count == 0)
            {
                Console.WriteLine("\nEmployees in your company is empty !!!");
                return;
            }

            Console.WriteLine("\n=== After sort by salary ===");
            DisplayEmployees(sortedEmps);

        }


        public static void SearchEmployeesById()
        {

            Console.WriteLine("\nEnter employee ID:");

            string searchId = Console.ReadLine();

            try
            {
                Employee searchEmp = employees.Find(e => e.EmpId == searchId);

                Console.WriteLine("\n=== After search by ID ===");
                searchEmp.Display();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Not found any employee with ID = {0}", searchId);
            }


        }

        public static void Main()
        {
            Console.WriteLine("Start Program ...");

            bool isValid;

            do
            {
                // Reset Value
                isValid = true;
                int option = EnterOption();

                string options = "1 2 3 4 5";

                if (!options.Contains(Convert.ToString(option)))
                {
                    isValid = false;
                    Console.WriteLine("Enter option invalid!");
                }

                if (isValid)
                {
                    switch (option)
                    {
                        case 1:
                            EnterEmployees();
                            break;
                        case 2:
                            DisplayEmployees(employees);
                            break;
                        case 3:
                            SoftEmployeesBySalary();
                            break;
                        case 4:
                            SearchEmployeesById();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }

            } while (true);
        }
    }
}

