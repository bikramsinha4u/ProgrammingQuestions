using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    class BinarySearch
    {
        public int[] InputArray { get; set; } = new int[] { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };

        public int Key { get; set; } = 60;

        public int Search(int[] arr, int key)
        {
            Array.Sort(arr); // { 10, 20, 30, 50, 60, 80, 100, 110, 130, 170 }

            int lower = 0;
            int upper = arr.Length - 1;
            
            while(upper >= lower)
            {
                int mid = (lower + upper) / 2;
                
                if (arr[mid] == key)
                {
                    return mid;
                }
                
                if (key > arr[mid])
                {
                    lower = mid + 1;
                }
                else // if (key < mid)
                {
                    upper = mid - 1;
                }
            }

            return -1;
        }

        public int SearchRecursive(int[] arr, int key, int lower, int upper)
        {
            if (upper >= lower)
            {
                int mid = (lower + upper) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }

                if (key < arr[mid])
                {
                    return SearchRecursive(arr, key, lower, mid - 1);
                }
                else
                {
                    return SearchRecursive(arr, key, mid + 1, upper);
                }
            }
            return -1;
        }
    }
}
/*
 * Auxiliary Space: O(1) in case of iterative implementation.
 * In the case of recursive implementation, O(Logn) recursion call stack space.
 */