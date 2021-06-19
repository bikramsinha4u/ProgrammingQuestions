using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class FindTwoNumbersAreEqual
    {
        int x = 2;
        int y = 2;

        public FindTwoNumbersAreEqual()
        {
            bool result = GetResult(x, y);
            Console.WriteLine($"Both numbers are equal: {result}");
        }

        public bool GetResult(int x, int y)
        {
            return (x ^ y) == 0;
        }
    }
}
