using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_156_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there, I'm going to be doing a couple things with DateTime.");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
            DateTime current = DateTime.Now;
            Console.WriteLine("The current Date Time is: {0}", current);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Now enter a number and I'll tell you the time it will be in that many hours.");
            Console.WriteLine("Hit Enter when finished.");
            string answer = Console.ReadLine();
            DateTime futureTime = DateTime.Now.AddHours(Convert.ToDouble(answer));
            Console.WriteLine("Based on your answer the future DateTime is {0}", futureTime);
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
