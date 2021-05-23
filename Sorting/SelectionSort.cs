using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class SelectionSort
    {
        public int[] InputArray { get; set; } = { 64, 25, 12, 22, 11 };

        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(arr, i, minIndex);
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
 * Auxiliary Space: O(1)
 * The good thing about selection sort is it never makes more than O(n) swaps and can be useful when memory write is a costly operation.
 */
