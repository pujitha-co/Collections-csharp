using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
     class Tuple
    {
        // Returns multiple values using a tuple

        static (string Name, double MonthlySalary, double AnnualSalary)
            GetEmployeeDetails(string name, double salary)
        {
            double annualSalary = salary * 12;

            return (name, salary, annualSalary);
        }

        static void Main()
        {
            // 1. Create a tuple
            var employee = (Id: 101,Name: "pujitha",Salary: 30000.0 );

            // 2. Access tuple values
            Console.WriteLine("Employee ID: " + employee.Id);
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Monthly Salary: " + employee.Salary);

            // 3. Update a tuple value
            employee.Salary = 35000;

            Console.WriteLine("\nUpdated Salary: " + employee.Salary);

            // 4. Return multiple values from a method
            var details = GetEmployeeDetails(employee.Name, employee.Salary);

            Console.WriteLine("\nEmployee Name: " + details.Name);
            Console.WriteLine("Monthly Salary: " + details.MonthlySalary);
            Console.WriteLine("Annual Salary: " + details.AnnualSalary);

            // 5. Deconstruction
            var (name, salary, annualSalary) = details;

            Console.WriteLine("Using Deconstruction:");
            Console.WriteLine(name);
            Console.WriteLine(salary);
            Console.WriteLine(annualSalary);

            // 6. Swap two values using tuple assignment
            int a = 10;
            int b = 20;

            (a, b) = (b, a);

            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);

            // 7. Compare tuples
            var first = (1, "Anu");
            var second = (1, "Anu");

            Console.WriteLine("\nTuples Equal: " + (first == second));
        }
    }
}
