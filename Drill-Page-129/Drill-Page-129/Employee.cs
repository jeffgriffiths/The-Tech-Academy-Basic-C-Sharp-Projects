using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_129
{
    class Employee : Person, IQuitTable
    {
        public int EmployeeId { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("The student above has thrown their keyboard against the wall and quit.");
        }

        public string CheckId(Employee employeeOne, Employee employeeTwo)
        {
            bool compareId = employeeOne.EmployeeId == employeeTwo.EmployeeId;
            string result = "";
            if (compareId)
            {
                result = "The Employee IDs match.";
            }
            else
            {
                result = "The Employee IDs do not match.";
            }
            return result;
        }
    }
}