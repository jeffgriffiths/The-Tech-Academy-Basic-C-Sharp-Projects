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
            int input1 = 0;
            int input2 = 0;
            int result = 0;


            Console.WriteLine("You will be asked for two numbers for a math operation.");
            Console.WriteLine("The second number is optional.");
            Console.WriteLine("Enter the first number:");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number (if you wish):");
            input2 = Convert.ToInt32(Console.ReadLine());


            if (input2 > 0)
            {
                result = input.DoMathStuff(input1, input2);
            }
            else
            {
                result = input.DoMathStuff(input1);
            }

            result = input.DoMathStuff(input1);

            Console.WriteLine("The result is: " + result);
            Console.ReadLine();

        }
    }
}
