using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number and I'll run some operations on it.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Math math = new Math();
            Console.WriteLine("Adding 2 to your number...");
            int sum = math.AddNumber(num1);
            Console.WriteLine(sum);

            Console.WriteLine("Dividing your number by 2...");
            int quotient = math.DivideNumber(num1);
            Console.WriteLine(quotient);

            Console.WriteLine("Multiplying your number by 2...");
            int product = math.MultiplyNumber(num1);
            Console.WriteLine(product);

            Console.WriteLine("That's it...hit Enter to end.");
            Console.ReadLine();
        }
    }
}
