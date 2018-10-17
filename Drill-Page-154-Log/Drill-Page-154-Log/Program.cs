using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill_Page_154_Log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number and press Enter.");
            string answer = Console.ReadLine();
            Console.WriteLine("Logging that number in log.txt on the desktop. Press any key...");
            Console.ReadKey();
            File.WriteAllText(@"C:\log.txt", answer);
            Console.WriteLine("Press any key to read the number back to the console.");
            Console.ReadKey();
            string text = File.ReadAllText(@"C:\log.txt");
            Console.WriteLine(text);
            Console.WriteLine("That's it, press any key to exit...");
            Console.ReadKey();


        }
    }
}
