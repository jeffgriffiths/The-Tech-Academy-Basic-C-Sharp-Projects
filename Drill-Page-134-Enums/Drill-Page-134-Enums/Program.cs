using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_134_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please spell out the current day of the week and press Enter.");
            try
            { 
                DaysOfTheWeek userInput = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine("That is an acceptable input. " + userInput + " is a day of the week.");
                Console.WriteLine("Press any key to exit...");

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week. Press any key to exit...");
            }
            finally
            {
                
                Console.ReadKey();
            }
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
