using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    class Math
    {
        public int DoMathStuff(int inputInt)
        {
            int resultAdd = inputInt + 2;
            return resultAdd;
        }

        public int DoMathStuff(double inputDecimal)
        {
            int resultDivide = Convert.ToInt32(inputDecimal) / 2;
            return resultDivide;
        }

        public int DoMathStuff(string inputString)
        {
            int resultMultiply = Convert.ToInt32(inputString) * 2;
            return resultMultiply;
        }
    }
}
