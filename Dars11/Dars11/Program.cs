namespace Dars11
{
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {

            //School school = CreateSchool();
            //FillSchoolObject(school);
            //Display(school);

            //Employee employee = CreateSchool();


            Employee employee1 = new Employee()
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Erkinbek",
                LastName = "Hasanov",
                Position = "Senior",
                Salary = 2000, // USD
                Age = 21,


            };
            Employee employee2 = new Employee()
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Jek",
                LastName = "Snow",
                Position = "Middle",
                Salary = 1500, // USD
                Age = 18,

            };

            AddEmployee(employee1);
            AddEmployee(employee2);

            DisplayEmployees();
            Console.WriteLine("Step 1");

            var newEmpoliyee = new Employee()
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Ted",
                LastName = "Mosby",
                Position = "Junior",
                Salary = 1000, // USD
                Age = 20,

            };

            UpdateEmployee(employee1.EmployeeId, newEmpoliyee);

            DisplayEmployees();
            Console.WriteLine("Spet 2");

            RemoveEmployee(employee2.EmployeeId);
            DisplayEmployees();







        }

        static void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        static void RemoveEmployee(Guid employeeId)
        {
            foreach (var employee in employees)
            {
                if (employee.EmployeeId == employeeId)
                {
                    employees.Remove(employee);
                    break;
                }
            }
        }

        static void UpdateEmployee(Guid employeeId, Employee newEmployee)
        {
            for (var i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeId == employeeId)
                {
                    newEmployee.EmployeeId = employeeId;
                    employees[i] = newEmployee;
                    break;
                }
            }
        }

        static void DisplayEmployees()
        {
            foreach (var employee in employees)
            {

                Console.WriteLine($" EmployeeId : {employee.EmployeeId}");
                Console.WriteLine($" First Name : {employee.FirstName}");
                Console.WriteLine($" Last Name : {employee.LastName}");
                Console.WriteLine($" Position: {employee.Position}");
                Console.WriteLine($" Salary: {employee.Salary}");
                Console.WriteLine();
                


            }
        }








        //static School CreateSchool()
        //{
        //    School school = new School();
        //    return school;
        //}

        //static void FillSchoolObject(School school)
        //{
        //    Console.Write("Maktab raqami : ");
        //    school.Number = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Maktab nomi : ");
        //    school.SchoolName = Console.ReadLine();
        //    Console.WriteLine("Maktab manzili : ");
        //    school.Location = Console.ReadLine();
        //    Console.WriteLine("Maktab sig'imi soni : ");
        //    school.Capacity = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Maktab talaba soni");
        //    school.CurrentStudentCount = int.Parse(Console.ReadLine());

        //}

        //static void Display ( School school)
        //{
        //    Console.WriteLine($"Maktab raqami :{school.Number} ");
        //    Console.WriteLine($"Maktab nomi :{school.SchoolName} ");
        //    Console.WriteLine($"Maktab manzili :{school.Location} ");
        //    Console.WriteLine($"Maktab sig'imi :{school.Capacity} ");
        //    Console.WriteLine($"Maktab talaba soni :{school.CurrentStudentCount} ");
        //    Console.WriteLine($" Bo'sh joylar soni : {(school.Capacity - school.CurrentStudentCount)}" );


        //}

    }
}
