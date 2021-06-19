using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Write an efficient program to count the number of 1s in the binary representation of an integer
    /// </summary>
    class CountSetBitsInNumber
    {
        int n = 6;

        public CountSetBitsInNumber()
        {
            int result = GetResult(n);
            Console.WriteLine($"Count of set bitss : {result}");
        }

        /// <summary>
        /// Θ(logn)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GetResult(int n)
        {
            int count = 0;

            while(n > 0)
            {
                if(n % 2 != 0)
                {
                    count++;
                }
                // or count += n & 1;
                n >>= 1;
            }

            return count;
        }

        /// <summary>
        /// Brian Kernighan’s Algorithm: 
        /// Subtracting 1 from a decimal number flips all the bits after the rightmost set bit(which is 1) including the rightmost set bit. 
        /// for example : 
        /// 10 in binary is 00001010 
        /// 9 in binary is 00001001 
        /// 8 in binary is 00001000 
        /// 7 in binary is 00000111 
        /// So if we subtract a number by 1 and do it bitwise & with itself (n & (n-1)), we unset the rightmost set bit. If we do n & (n-1) in a loop and count the number of times the loop executes, we get the set bit count. 
        /// The beauty of this solution is the number of times it loops is equal to the number of set bits in a given integer.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GetResult_M2(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n &= (n - 1);
                count++;
            }
            return count;
        }
    }
}
