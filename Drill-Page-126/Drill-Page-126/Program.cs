using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_126
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuitTable employeeQuit = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            employeeQuit.Quit();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
