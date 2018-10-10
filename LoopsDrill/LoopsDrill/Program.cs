using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[6];
            names[0] = "Jeff";
            names[1] = "Josh";
            names[2] = "Jon";
            names[3] = "Ryan";
            names[4] = "Marc";
            names[5] = "";

            Console.WriteLine("What is your first name?");
            names[5] = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

            //for (int i = 0; i < 1; i++, i--)
            //{
            //    Console.WriteLine("This is an example of an infinite loop...");
            //}

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("This is a correction of the infinite loop...");
            }

            int stopNumber = 5;

            for (int a = 0; a < stopNumber; a++)
            {
                Console.WriteLine(stopNumber * a);
            }

            for (int b = 0; b <= stopNumber; b++)
            {
                Console.WriteLine(stopNumber + b);
            }
            Console.ReadLine();

            List<string> petList = new List<string>() { "cat", "dog", "bunny", "hamster", "turtle", "fish", "snake" };
            Console.WriteLine("Type a pet type to search for its location in the pet list.");
            string petAnswer = Console.ReadLine();

            for (int c = 0; c < petList.Count; c++)
            {
                //Console.WriteLine(petList[c]);
                if (petList[c] == petAnswer)
                {

                    Console.WriteLine("That animal is listed at index: " + petList.IndexOf(petList[c]));
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("That animal is not found in the pet list");
                    Console.ReadLine();
                }
            }

            List<string> sportList = new List<string>() { "basketball", "hockey", "soccer", "football", "soccer", "tennis", "golf", "baseball" };
            Console.WriteLine("Type the name of a sport to search for its location in the list.");
            string sportAnswer = Console.ReadLine();

            for (int i = 0; i < sportList.Count; i++)
            {
                if (sportList[i] == sportAnswer)
                {

                    Console.WriteLine("That sport is listed at index: " + sportList.IndexOf(sportList[i]));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That sport is not found in this list");
                    Console.ReadLine();
                }
            }

            List<string> cerealList = new List<string>() { "Captain Crunch", "Cheerios", "Frosted Flakes", "Cheerios", "Sugar Smacks" };

            foreach (string cerealName in cerealList)
            {
                Console.WriteLine(cerealName);
                //Console.ReadLine();

                List<string> iList = new List<string>();
                for (int i = 0; i < cerealList.Count; i++ )
                {
                    if (cerealList[i] == cerealName)
                    {
                        iList.Add(cerealName);
                    }
                }

                if (iList.Count > 1)
                {
                    Console.WriteLine("This type exists multiple times."); 
                }
   
                Console.ReadLine();
            }

        }
    }
}
