using System;

namespace ProgrammingQuestions
{
    internal class LargestSumContiguousSubarray
    {
        public static void Caller()
        {
            var input = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            Find(input);
        }
        public static void Find(int[] arr)
        {
            var maxSoFar = int.MinValue;
            var currentSum = 0;

            foreach (var item in arr)
            {
                currentSum += item;

                if (maxSoFar < currentSum)
                    maxSoFar = currentSum;

                if (currentSum < 0)
                    currentSum = 0;
            }

            Console.WriteLine($"Max sum of subarray: {maxSoFar}");
        }
    }
}
