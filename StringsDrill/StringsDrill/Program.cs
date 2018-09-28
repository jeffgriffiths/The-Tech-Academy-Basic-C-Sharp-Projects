using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDrill
{
    class Program
    {
        static void Main()
        {
            string fname = "Shawn";
            string lname = "Kemp";
            string message = "is the greatest PF of all time.\n";

            string youKnowIt = fname + " " + lname + " " + message;
            Console.WriteLine(youKnowIt);

            string uCase = youKnowIt.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append("Shawn Travis Kemp (born November 26, 1969) is an American retired professional basketball player, who played in the National Basketball Association (NBA) for 14 seasons.");
            sb.Append("\nHe was a six-time NBA All-Star and a three-time All-NBA Second Team member.");
            sb.Append("\nHe was better than Buck Williams.");
            sb.Append("\nHe was better than Cliff Robinson.");
            sb.Append("\nHe was better than Rasheed Wallace.");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
