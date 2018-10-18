using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_165_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");            
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0 || age < 0)
                {
                    throw (new UseRealAgeException("Negative and 0 are not an allowable age"));   
                }
                else
                {
                    var today = DateTime.Today.Year;
                    var yearOfBirth = today - age;
                    Console.WriteLine("You were born in:");
                    Console.WriteLine(yearOfBirth);
                }
            }
            catch (UseRealAgeException oex)
            {
                Console.WriteLine(oex.Message.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Error, you entered something other than an integer.");
            }
            finally
            {
                Console.WriteLine("Press enter to end.");
                Console.ReadLine();
            }
            
        }
        
        public class UseRealAgeException : Exception
        {
            public UseRealAgeException(string message)
                : base(message)
            {
            }
        }
    }   
}
