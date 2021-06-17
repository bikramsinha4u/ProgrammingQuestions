using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Given an array where every element occurs three times, except one element which occurs only once. Find the element that occurs once. Expected time complexity is O(n) and O(1) extra space. 
    /// </summary>
    public class ElementAppearOnce
    {
        public int[] InputArrayRepeatedTwice { get; set; } = { 1, 1, 2, 2, 3, 3, 4 };
        public int[] InputArrayRepeatedThrice { get; set; } = { 12, 1, 12, 3, 12, 1, 1, 2, 3, 3 };

        public int GetElementAppearingOnceOtherRepeatedTwice()
        {
            int result = 0;
            foreach (var item in InputArrayRepeatedTwice)
            {
                result ^= item;
            }

            return result;
        }

        public int GetElementAppearingOnceOtherRepeatedThrice()
        {
            int ones = 0, twos = 0;

            foreach (var item in InputArrayRepeatedThrice)
            {
                ones = (ones ^ item) & ~twos;
                twos = (twos ^ item) & ~ones;
            }

            return ones;
        }
    }
}
