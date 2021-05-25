using System;

namespace Sorting
{
    class StartupProgram
    {
        static void Main(string[] args)
        {
            //SelectionSort selectionSort = new SelectionSort();
            //selectionSort.Sort(selectionSort.InputArray);
            //Console.WriteLine($"Sorted Array: [{String.Join(", ", selectionSort.InputArray)}]");

            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.Sort(bubbleSort.InputArray);
            //Console.WriteLine($"Sorted Array: [{String.Join(", ", bubbleSort.InputArray)}]");

            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.Sort(insertionSort.InputArray);
            //insertionSort.Sort2(insertionSort.InputArray);
            //insertionSort.Sort3(insertionSort.InputArray);
            //Console.WriteLine($"Sorted Array: [{String.Join(", ", insertionSort.InputArray)}]");

            //MergeSort mergeSort = new MergeSort();
            //mergeSort.Sort(mergeSort.InputArray, 0, mergeSort.InputArray.Length - 1);
            //Console.WriteLine($"Sorted Array: [{String.Join(", ", mergeSort.InputArray)}]");

            QuickSort quickSort = new QuickSort();
            quickSort.Sort(quickSort.InputArray, 0, quickSort.InputArray.Length - 1);
            Console.WriteLine($"Sorted Array: [{String.Join(", ", quickSort.InputArray)}]");

            Console.ReadKey();
        }
    }
}
