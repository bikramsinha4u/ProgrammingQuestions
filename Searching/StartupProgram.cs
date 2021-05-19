using System;

namespace Searching
{
    class StartupProgram
    {
        static void Main(string[] args)
        {
            LinearSearch linearSearch = new LinearSearch();
            int output = linearSearch.Search(linearSearch.InputArray, linearSearch.Key);
            Console.WriteLine($"Liner Search Output: {output}");



            Console.ReadKey(); // To keep the output console persist.
        }
    }
}
