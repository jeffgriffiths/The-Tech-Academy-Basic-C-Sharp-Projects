using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Drill
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            { 
                List<int> numList = new List<int>() { 3, 45, 7, 78, 43, 12 };

                Console.WriteLine("Enter an integer and I'll divide each number in my list by that number");
                int userNum = Convert.ToInt32(Console.ReadLine());
            
                for (int i = 0; i < numList.Count; i++)
                {
                    int quotient = numList[i] / userNum;
                    Console.WriteLine(quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("You did something bad!");
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("You've exited the try-catch block.");
            Console.ReadLine();
        }
    }
}
