using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill5
{
    class Math
    {
        public void DoMathStuff(int inputInt)
        {
            int resultDivide = inputInt / 2;
            Console.WriteLine("The result is: " + resultDivide);
        }

        public void DoMathStuff(double inputInt)
        {
            double resultDivide = inputInt / 2;
            Console.WriteLine("The result is: " + resultDivide);
        }

        public void GetValue(out int inputInt)
        {
            inputInt = Convert.ToInt32(Console.ReadLine());
        }
    }
}
