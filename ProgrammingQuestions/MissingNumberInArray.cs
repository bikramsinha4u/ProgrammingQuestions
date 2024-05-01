using System;
using System.Linq;

namespace ProgrammingQuestions
{
    internal class MissingNumberInArray
    {
            public static void Caller()
            {
                var input = new int[] { 1, 6, 3, 4, 5, 7 };
                Find(input, input.Length + 1);
                Find2(input, input.Length + 1);
            }
            public static void Find(int[] arr, int N)
            {
                var temp = Enumerable.Range(0, N + 1).ToArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    temp[arr[i]] = 1;
                }

                foreach (var item in temp.Skip(1))
                {
                    if (item != 1)
                    {
                        Console.WriteLine($"Missing number in array is: {item}");
                    } 
                }
            }

            public static void Find2(int[] arr, int N)
            {
                var totalSum = N * (N + 1) / 2;
                var actualSum = 0;
            
                foreach (var item in arr) 
                { 
                    actualSum += item;
                }

                Console.WriteLine($"Missing number in array is: {totalSum - actualSum}");
            }
    }
}
