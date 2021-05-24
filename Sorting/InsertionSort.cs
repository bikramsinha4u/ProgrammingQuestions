using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class InsertionSort
    {
        public int[] InputArray { get; set; } = { 4, 3, 2, 10, 12, 1, 5, 6 };

        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] < arr[i])
                {
                    FindInsertPosition(arr, i + 1);
                }
            }
        }

        public void FindInsertPosition(int[] arr, int currentPosition)
        {
            int key = arr[currentPosition];
            int insertPosition = currentPosition;
            for (int i = 0; i < currentPosition; i++)
            {
                if (arr[i] > key)
                {
                    insertPosition = i;
                    break;
                }
            }

            RightShiftAndInsert(arr, insertPosition, currentPosition);
        }

        public void RightShiftAndInsert(int[] arr, int insertPosition, int currentPosition)
        {
            int key = arr[currentPosition];
            for (int i = currentPosition; i > insertPosition; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[insertPosition] = key;
        }

        /// <summary>
        /// G4G solution
        /// </summary>
        /// <param name="arr"></param>
        public void Sort2(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public void Sort3(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
/*
 * Boundary Cases: Insertion sort takes maximum time to sort if elements are sorted in reverse order. And it takes minimum time (Order of n) when elements are already sorted.
 * Algorithmic Paradigm: Incremental Approach
 * Sorting In Place: Yes
 * Stable: Yes
 * Online: Yes
 */