using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            Math input = new Math();
            int result;
            
            Console.WriteLine("You will be asked for two numbers for a math operation.");
            Console.WriteLine("The second number is optional.");
            Console.WriteLine("Enter the first number:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number (if you wish) and press Enter.");
            string input2 = Console.ReadLine();

            bool isEmpty = string.IsNullOrEmpty(input2);

            if (!isEmpty)
            {
                result = input.DoMathStuff(input1, Convert.ToInt32(input2));
            }
            else
            {
                Console.WriteLine("You chose not to enter a second number. The default will be used.");
                result = input.DoMathStuff(input1);
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
