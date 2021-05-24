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

            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Sort(insertionSort.InputArray);
            //insertionSort.Sort2(insertionSort.InputArray);
            //insertionSort.Sort3(insertionSort.InputArray);
            Console.WriteLine($"Sorted Array: [{String.Join(", ", insertionSort.InputArray)}]");

            Console.ReadKey();
        }
    }
}
