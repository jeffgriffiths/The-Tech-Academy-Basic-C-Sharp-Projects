using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_140_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new List<Employee>();

            employeeList.Add(new Employee("John", "Smith", 123456));
            employeeList.Add(new Employee("Randy", "Jones", 098765));
            employeeList.Add(new Employee("Ed", "Scott", 394589));
            employeeList.Add(new Employee("Joe", "Wilson", 129493));
            employeeList.Add(new Employee("Laura", "Rott", 113452));
            employeeList.Add(new Employee("Ray", "Lopez", 089939));
            employeeList.Add(new Employee("Nate", "Walrath", 838274));
            employeeList.Add(new Employee("Debbie", "Marshall", 938284));
            employeeList.Add(new Employee("Josh", "Thompson", 384802));
            employeeList.Add(new Employee("Joe", "Yundt", 999478));

            var newList1 = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    newList1.Add(new Employee(employee.FirstName, employee.LastName, employee.ID));
                }
            }

            Console.WriteLine("Press any key to see the employee's named \"Joe\" found with a foreach loop.");
            Console.ReadKey();

            for (int i = 0; i < newList1.Count; i++)
            {
                Console.WriteLine("Name: " + newList1[i].FirstName + " " + newList1[i].LastName);
            }

            Console.WriteLine("Now the same thing with a lambda expression. Press any key...");
            Console.ReadKey();

            foreach(Employee employee in employeeList.FindAll(t =>(t.FirstName == "Joe")).ToList())
            {
                Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName);
            }

            Console.WriteLine("Now checking for employees with an ID greater than 5. Press any key...");
            Console.ReadKey();

            foreach (Employee employee in employeeList.FindAll(t => (t.ID > 5)).ToList())
            {
                Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName + "\t\tID: " + employee.ID);
            }

            Console.WriteLine("That's it. Press any key to exit...");
            Console.ReadKey();
            
        }
    }
    
}
