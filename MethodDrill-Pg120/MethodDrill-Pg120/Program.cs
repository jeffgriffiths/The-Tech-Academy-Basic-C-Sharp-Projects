﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill_Pg120
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            Console.ReadLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
