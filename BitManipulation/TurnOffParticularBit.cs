using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Given a number n and a value k, turn off the k’th bit in n. Please note that k = 1 means the rightmost bit
    /// </summary>
    class TurnOffParticularBit
    {
        int n = 7;
        int k = 2;

        public TurnOffParticularBit()
        {
            int result = GetResult(n, k);
            Console.WriteLine($"result is: {result}");
        }

        public int GetResult(int n, int k)
        {
            if (n == 0)
            {
                return -1;
            }

            return n & ~(1 << (k - 1));
        }
    }
}
