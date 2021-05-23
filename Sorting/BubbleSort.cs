using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class BubbleSort
    {
        public int[] InputArray { get; set; } = { 64, 25, 12, 22, 11 };

        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        Swap(arr, j, j + 1);
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
/* 
 * Best Case Time Complexity: O(n). Best case occurs when array is already sorted.
 * Sorting In Place: Yes
 * Stable: Yes
 */

