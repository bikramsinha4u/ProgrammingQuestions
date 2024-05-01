using System;

namespace ProgrammingQuestions
{
    internal class NextGreaterElement
    {
        public static void Caller()
        {
            var input = new int[] { 1, 3, 2, 4 };
            Find(input);
        }
        public static void Find(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        Console.WriteLine($"Nearest greater element to the right of {arr[i]}: {arr[j]}");
                        break;
                    }
                }
                if (i == arr.Length - 1)
                {
                    Console.WriteLine($"Nearest greater element to the right of {arr[i]}: -1");
                }
            }
        }
    }
}
