using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class FindRightmostSetBit
    {
        int n = 3;

        public FindRightmostSetBit()
        {
            int result = GetResult(n);
            Console.WriteLine($"Rightmost set bit position is: {result}");
        }

        public int GetResult(int n)
        {
            int pos = 1;
            while(n > 0)
            {
                if ((n & 1) > 0)
                {
                    return pos;
                }

                pos++;
                n = n >> 1;
            }

            return -1;
        }
    }
}
