using System;

namespace MathAndComparisonDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is their hourly rate?");
            decimal personOneRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours/week?");
            decimal personOneHours = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("What is their hourly rate?");
            decimal personTwoRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours/week?");
            decimal personTwoHours = Convert.ToDecimal(Console.ReadLine());
            decimal personOneSalary = personOneRate * personOneHours * 52;
            decimal personTwoSalary = personTwoRate * personTwoHours * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(personOneSalary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(personTwoSalary);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool personOneHigherComp = personOneSalary > personTwoSalary;
            Console.WriteLine(personOneHigherComp);
            Console.Read();
        }
    }
}
