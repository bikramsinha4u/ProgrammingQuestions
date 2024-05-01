using System;

namespace ProgrammingQuestions
{
    internal class LeadersInArray
    {
        public static void Caller()
        {
            var arr = new int[] { 16, 17, 4, 3, 5, 2 };
            Console.Write("Leaders in array are: ");
            PrintLeaders(arr);
            Console.WriteLine();
        }

        public static void PrintLeaders(int[] arr)
        {
            int max_from_right = arr[arr.Length - 1];

            Console.Write(max_from_right + " ");

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (max_from_right < arr[i])
                {
                    max_from_right = arr[i];
                    Console.Write(max_from_right + " ");
                }
            }
        }
    }
}
