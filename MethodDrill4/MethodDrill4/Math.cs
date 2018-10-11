using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill4
{
    class Math
    {
        public int DoMathStuff(int num1, int num2 = 2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
