using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    /// <summary>
    /// Time complexity: θ(nLogn) in all 3 cases (worst, average and best)
    /// as merge sort always divides the array into two halves and takes linear time to merge two halves.
    /// Auxiliary Space: O(n)
    /// Sorting In Place: No in a typical implementation
    /// Stable: Yes
    /// </summary>
    class MergeSort
    {
        public int[] InputArray { get; set; } = { 12, 11, 13, 5, 6, 7 };

        /// <summary>
        /// Merges two subarrays of []arr.
        /// First subarray is arr[l..m]
        /// Second subarray is arr[m+1..r]
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="l">Left index</param>
        /// <param name="m">Middle index</param>
        /// <param name="r">Right index</param>
        public void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];

            // Copy data to temp arrays
            for (int p = 0; p < n1; ++p)
                L[p] = arr[l + p];
            for (int q = 0; q < n2; ++q)
                R[q] = arr[m + 1 + q];

            // Initial indexes of first and second subarrays
            int i = 0;
            int j = 0;

            // Initial index of merged subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i]; // *
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        /// <summary>
        /// Main function that sorts arr[l..r] using merge()
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="l">Left index</param>
        /// <param name="r">Right index</param>
        public void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point
                int m = (l + r) / 2;

                // Sort first and second halves
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                // Merge the sorted halves
                Merge(arr, l, m, r);
            }
        }
    }
}
/*
 * https://www.youtube.com/watch?v=i56B0xN7jSc
 */