using System;

namespace Searching
{
    class StartupProgram
    {
        static void Main(string[] args)
        {
            //LinearSearch linearSearch = new LinearSearch();
            //int linearSearchOutput = linearSearch.Search(linearSearch.InputArray, linearSearch.Key);
            //Console.WriteLine($"Liner Search Output: {linearSearchOutput}");

            //BinarySearch binarySearch = new BinarySearch();
            //int binarySearchOutput = binarySearch.Search(binarySearch.InputArray, binarySearch.Key);
            //Console.WriteLine($"Binary Search Output: {binarySearchOutput}");

            BinarySearch binarySearch = new BinarySearch();
            Array.Sort(binarySearch.InputArray);
            int binarySearchOutput = binarySearch.SearchRecursive(binarySearch.InputArray, binarySearch.Key, 0, binarySearch.InputArray.Length - 1);
            Console.WriteLine($"Binary Search recursive Output: {binarySearchOutput}");

            Console.ReadKey(); // To keep the output console persist.
        }
    }
}
