using System;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("This program will use a while loop to count to 10.");
            Console.WriteLine("Press enter to start.");
            Console.ReadLine();

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            int a = 10;

            Console.WriteLine("Now it will count back down using a do while loop.");
            Console.WriteLine("Press enter to start.");
            Console.ReadLine();

            do
            {
                Console.WriteLine(a);
                a--;
            } while (a > 0);

            Console.ReadLine();

        }
    }
}
