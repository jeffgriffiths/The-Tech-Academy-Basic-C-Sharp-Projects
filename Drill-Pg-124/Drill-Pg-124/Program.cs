using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Pg_124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            Console.WriteLine("The text above was generated using an abstract class and method");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
