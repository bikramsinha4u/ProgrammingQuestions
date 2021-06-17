using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Write a program that unsets the rightmost set bit of an integer
    /// </summary>
    class TurnOffRightmostSetBit
    {
        int x = 7;

        public TurnOffRightmostSetBit()
        {
            int result = GetResult();
            Console.WriteLine($"Result of setting off the rightmost bit of {x} equals {result}");    
        }

        public int GetResult()
        {
            return x & (x - 1);
        }
    }
}
