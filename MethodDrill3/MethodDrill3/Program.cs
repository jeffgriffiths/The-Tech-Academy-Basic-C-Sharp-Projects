using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math add = new Math();
            Math divide = new Math();
            Math multiply = new Math();

            Console.WriteLine("Please enter an integer.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int sum = add.DoMathStuff(inputInt: num1);
            Console.WriteLine("The result of the first call is " + sum + ".");

            Console.WriteLine("Please enter a decimal number.");
            double num2 = Convert.ToDouble(Console.ReadLine());
            int quotient = divide.DoMathStuff(inputDecimal: num2);
            Console.WriteLine("The result of the second call is " + quotient + ".");

            Console.WriteLine("Please enter a last number.");
            string num3 = Console.ReadLine();
            int product = multiply.DoMathStuff(inputString: num3);
            Console.WriteLine("The result of the second call is " + product + ".");

            Console.ReadLine();

        }
    }
}
