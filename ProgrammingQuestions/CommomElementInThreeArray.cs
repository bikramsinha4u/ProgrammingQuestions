using System;
using System.Linq;

namespace ProgrammingQuestions
{
    internal class CommomElementInThreeArray
    {
        public static void Caller()
        {
            var input1 = new int[] { 1, 5, 10, 20, 40, 80 };
            var input2 = new int[] { 6, 7, 20, 80, 100 };
            var input3 = new int[] { 3, 4, 15, 20, 30, 70, 80, 120 };
            Find(input1, input2, input3);
        }
        public static void Find(int[] arr1,int[] arr2,int[] arr3)
        {
            var result = arr1.Intersect(arr2).Intersect(arr3);
            //result = arr1.Union(arr2).Union(arr3);

            Console.WriteLine($"Second Largest: {string.Join(',', result)}");
        }
    }
}
