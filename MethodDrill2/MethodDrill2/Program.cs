using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math number = new Math();
            number.doStuff(1, 2);
            number.doStuff(numberOne: 3, numberTwo: 4);
            Console.ReadLine();
        }
    }
}
