using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill5
{
    class Program
    {
        static void Main(string[] args)
        {
            Math number = new Math();
            Console.WriteLine("Enter a number and I'll divide it by 2.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            number.DoMathStuff(inputInt: num1);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Displaying a message from my static class...");
            Static.StaticMethodMessage();
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
