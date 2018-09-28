using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[] { "Gary Payton", "Shawn Kemp", "Hersey Hawkins", "Detlef Schrempf", "Sam Perkins" };

            Console.WriteLine("Enter a number between 0 and 4.");
            int answerOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strArray[answerOne]);

            int[] intArray = new int[] { 20, 40, 33, 11, 14 };

            Console.WriteLine("Enter another number between 0 and 4.");
            int answerTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intArray[answerTwo]);

            List<string> strList = new List<string>();
            strList.Add("David Wingate");
            strList.Add("Eric Snow");
            strList.Add("Craig Ehlo");
            strList.Add("Jim McIlvaine");
            strList.Add("Terry Cummings");

            Console.WriteLine("Enter one more number between 0 and 4.");
            int answerThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strList[answerThree]);

            Console.ReadLine();

        }
    }
}
