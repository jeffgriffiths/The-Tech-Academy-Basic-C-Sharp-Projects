using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Page_162
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fName = "Jeff";
            Console.WriteLine("Printing a name using a constant: fName is {0}", fName);
            var fullName = "Jeff Griffiths";
            Console.WriteLine("Printing a name using var: {0}", fullName);
            Person person1 = new Person("Jeff Griffiths");
            Person person2 = new Person("Jeff Griffiths", "Boise");
            Console.WriteLine("Printing chained constructor with one parameter:");
            person1.PrintPerson();
            Console.WriteLine("Printing chained constructor with both parameters:");
            person2.PrintPerson();
            Console.WriteLine("That's it. Press any key to exit...");
            Console.ReadKey();
        }
        class Person
        { 

            public string name;
            public string city;

        
            public Person(string s1) : this(s1, "")
            {
            }

            public Person(string s1, string s2)
            {
                name = s1;
                city = s2;
            }

            public void PrintPerson()
            {
                Console.WriteLine("{0} {1}", name, city);
            }
        }
    }
}
