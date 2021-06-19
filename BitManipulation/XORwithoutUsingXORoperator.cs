using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class XORwithoutUsingXORoperator
    {
        int x = 2, y = 3;

        public XORwithoutUsingXORoperator()
        {
            int result = GetResult(x, y);
            Console.WriteLine($"Value of XOR equals: {result}");
        }

        public int GetResult(int x, int y)
        {
            return (x | y) & (~x | ~y);
            // or return (x & ~y) | (~x & y);
        }
    }
}
