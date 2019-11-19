using System;

namespace classes
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company companyA = new Company("CompanyA", new DateTime(2013, 01, 03));

            // Create three employees
            Employee employee1 = new Employee()
            {
                FirstName = "Sid",
                LastName = "Hueman",
                Title = "Sales Manager",
                StartDate = new DateTime(2018, 06, 01)

            };

            Employee employee2 = new Employee()
            {
                FirstName = "Max",
                LastName = "Payne",
                Title = "HR",
                StartDate = new DateTime(2014, 08, 15)

            };

            Employee employee3 = new Employee()
            {
                FirstName = "Cinde",
                LastName = "Rella",
                Title = "CEO",
                StartDate = new DateTime(2013, 09, 12)

            };

            // Assign the employees to the company
            companyA.Employees.Add(employee1);
            companyA.Employees.Add(employee2);
            companyA.Employees.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee employee in companyA.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for CompanyA as a {employee.Title} since {employee.StartDate}");
            }
        }
    }
}