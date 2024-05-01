using System;

namespace ProgrammingQuestions
{
    internal class RotateArray
    {
        public static void Caller()
        {
            var input = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            var d = 3;
            Rotate(input, d);
        }

        public static void Rotate(int[] arr, int d)
        {
            var size = arr.Length;
            Console.WriteLine($"Input array: \n{string.Join(',', arr)}");

            while (d > 0)
            {
                int i = 0;
                var temp = arr[i];
                for (; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[i] = temp;
                d--;
            }

            Console.WriteLine($"Rotated array by {d}: \n{string.Join(',', arr)}");
        }
    }
}
