using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_137_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number straightCashHomie = new Number();

            straightCashHomie.Amount = 300.5m;

            Console.WriteLine("This is the amount assigned to the Number variable:");
            Console.WriteLine(straightCashHomie.Amount);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
