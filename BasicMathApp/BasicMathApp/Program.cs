using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and I'll multiply it by 50.");
            uint firstNumber = Convert.ToUInt32(Console.ReadLine());
            uint product = firstNumber * 50;
            Console.WriteLine(product);
            Console.WriteLine("Enter a number and this time I'll add 25 to it.");
            uint secondNumber = Convert.ToUInt32(Console.ReadLine());
            uint sum = secondNumber + 25;
            Console.WriteLine(sum);
            Console.WriteLine("Isn't this fun? Enter a number and now I'll divide it by 12.5.");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            double quotient = thirdNumber / 12.5;
            Console.WriteLine(quotient);
            Console.WriteLine("Not done yet...Enter a number and I'll see if it's greater than 50.");
            double fourthNumber = Convert.ToDouble(Console.ReadLine());
            bool moreThanFifty = fourthNumber > 50;
            Console.WriteLine(moreThanFifty);
            Console.WriteLine("Okay, last one. I'll divide and look for a remainder");
            uint fifthNumber = Convert.ToUInt32(Console.ReadLine());
            uint remainder = fifthNumber % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
