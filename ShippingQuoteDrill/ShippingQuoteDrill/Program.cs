using System;
using static System.Net.Mime.MediaTypeNames;

namespace ShippingQuoteDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is your package weight?");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Your package is too heavy to ship");
                Console.ReadLine();
                System.Environment.Exit(0); 
            }
            Console.WriteLine("What is your package width?");
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is your package length?");
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());
            decimal total = packageWidth + packageHeight + packageLength;
            if (total < 50) 
            {
                decimal quote = total * packageWeight / 100;
                string output = quote.ToString("$#,##0.00");
                Console.WriteLine("Your quote is:");
                Console.WriteLine(output);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

        }
    }
}
