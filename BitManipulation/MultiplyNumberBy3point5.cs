using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Given an integer x, write a function that multiplies x with 3.5 and returns the integer result. You are not allowed to use %, /, *. 
    /// </summary>
    class MultiplyNumberBy3point5
    {
        readonly int x = 2;

        public MultiplyNumberBy3point5()
        {
            int result = GetResultOfMultiplyingNumberBy3Point5();
            Console.WriteLine($"Multiplying the number {x} by 3.5 equals {result}");
        }

        /// <summary>
        /// We can get x*3.5 by adding 2*x, x and x/2. To calculate 2*x, left shift x by 1 and to calculate x/2, right shift x by 2. 
        /// </summary>
        /// <returns></returns>
        public int GetResultOfMultiplyingNumberBy3Point5()
        {
            return (x << 1) + x + (x >> 1);
        }

        /// <summary>
        /// Another way of doing this could be (8*x – x)/2 (See below code)
        /// </summary>
        /// <returns></returns>
        public int GetResultOfMultiplyingNumberBy3Point5_M2()
        {
            return ((x << 3) - x) >> 1;
        }
    }
}
