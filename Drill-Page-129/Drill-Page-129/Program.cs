using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee();
            Employee employeeTwo = new Employee();

            Console.WriteLine("Lets check if the employee IDs match...");
            Console.WriteLine("Input the first employees ID and press Enter.");
            employeeOne.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second employees ID and press Enter.");
            employeeTwo.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(employeeOne.CheckId(employeeOne, employeeTwo));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
