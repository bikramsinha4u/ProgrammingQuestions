using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class SwapTwoNumbersWithoutTempVar
    {
        int x = 2, y = 3;

        public SwapTwoNumbersWithoutTempVar()
        {
            GetResult_M2(ref x, ref y);
            Console.WriteLine($"Now x is {x}, y is {y}");
        }

        public void GetResult(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }

        public void GetResult_M2(ref int x, ref int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }
    }
}
/*
x = x * y;
y = x / y;
x = x / y;
*/