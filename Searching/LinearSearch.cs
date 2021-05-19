using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    class LinearSearch
    {
        public int[] InputArray { get; set; } = new int[] { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };
        
        public int Key { get; set; } = 110;

        public int Search(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
