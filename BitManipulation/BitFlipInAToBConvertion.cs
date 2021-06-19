using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Given two numbers ‘a’ and b’. Write a program to count number of bits needed to be flipped to convert ‘a’ to ‘b’
    /// </summary>
    class BitFlipInAToBConvertion
    {
        int x = 2, y = 3;

        public BitFlipInAToBConvertion()
        {
            int result = GetResult(x, y);
            Console.WriteLine($"Count of bits to be flipped : {result}");
        }

        public int GetResult(int x, int y)
        {
            int n = x ^ y;
            int count = 0;

            while (n > 0)
            {
                n = n & (n - 1);
                count++;
            }

            return count;
        }
    }
}
