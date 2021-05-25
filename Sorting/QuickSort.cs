using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class QuickSort
    {
        public int[] InputArray { get; set; } = { 10, 80, 30, 90, 40, 50, 70 };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low">Start Index</param>
        /// <param name="high">Array Length</param>
        /// <returns></returns>
        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low]; // Taking first element as pivot
            int i = low;
            int j = high + 1; // *

            while (i < j)
            {
                do
                {
                    i++;
                } while (arr[i] <= pivot);

                do
                {
                    j--;
                } while (arr[j] > pivot);

                if(i < j)
                {
                    Swap(arr, i, j);
                }
            }

            Swap(arr, low, j);

            return j;
        }

        public void Swap(int[] arr, int p, int q)
        {
            int temp = arr[p];
            arr[p] = arr[q];
            arr[q] = temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low">Start index</param>
        /// <param name="high">End Index</param>
        public void Sort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int j = Partition(arr, low, high);

                Sort(arr, low, j - 1);
                Sort(arr, j + 1, high);
            }
        }
    }
}
