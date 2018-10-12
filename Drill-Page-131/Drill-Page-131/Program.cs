using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeOne = new Employee<string>();
            Employee<int> employeeTwo = new Employee<int>();
            employeeOne.Things = new List<string>() { "Watch", "Belt", "Hat" };
            employeeTwo.Things = new List<int>() { 1, 2, 3 };

            Console.WriteLine("Going to write out the employee things lists. Press any key...");
            Console.ReadKey();

            employeeOne.ListThings();
            employeeTwo.ListThings();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
