using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class NumberIsPowerOf4
    {
        int x = 7;

        public NumberIsPowerOf4()
        {
            //bool result = GetResult(x);
            //Console.WriteLine($"{x} is power of 4: {result}");

            bool result = GetResult_M2(x);
            Console.WriteLine($"{x} is power of 4: {result}");
        }

        /// <summary>
        /// Time Complexity: O(log4n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool GetResult(int n)
        {
            if (n == 0)
            {
                return false;
            }

            while (n != 1)
            {
                if (n % 4 != 0)
                {
                    return false;
                }

                n /= 4;
            }

            return true;
        }

        /// <summary>
        /// A number n is a power of 4 if the following conditions are met. 
        /// a) There is only one bit set in the binary representation of n (or n is a power of 2) 
        /// b) The count of zero bits before the (only) set bit is even.
        /// For example 16 (10000) is the power of 4 because there is only one bit set and count of 0s before the set bit is 4 which is even.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool GetResult_M2(int n)
        {
            int count = 0;
            int x = n & (n - 1);

            if (n > 0 && x == 0)
            {
                while (n > 1)
                {
                    n >>= 1;
                    count += 1;
                }

                //If count is even then return true else false
                return (count % 2 == 0) ? true : false;
            }

            return false;
        }

        /// <summary>
        /// A number will be a power of 4 if floor(log4(num))=ceil(log4(num) because log4 of a number that is a power of 4 will always be an integer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool GetResult_M3(int n)
        {
            if (n == 0)
            {
                return false;
            }

            return Math.Floor(logn(n, 4)) == Math.Ceiling(logn(n, 4));
        }

        private double logn(int n, int r)
        {
            return Math.Log(n) / Math.Log(r);
        }
    }
}
