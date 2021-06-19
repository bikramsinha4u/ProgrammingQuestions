using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class MultiplyBy7
    {
        int n = 3;

        public MultiplyBy7()
        {
            int result = GetResult(n);
            Console.WriteLine($"{n} multiplied by 7 is: {result}");
        }

        public int GetResult(int n)
        {
            return (n << 3) - n;
        }
    }
}
