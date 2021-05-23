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

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(bubbleSort.InputArray);
            Console.WriteLine($"Sorted Array: [{String.Join(", ", bubbleSort.InputArray)}]");

            Console.ReadKey();
        }
    }
}
