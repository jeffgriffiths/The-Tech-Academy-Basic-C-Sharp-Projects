using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_126
{
    class Employee : Person, IQuitTable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("The student above has thrown their keyboard against the wall and quit.");
        }
    }
}
