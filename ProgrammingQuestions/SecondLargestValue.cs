using System;

namespace ProgrammingQuestions
{
    public class SecondLargestValue
    {
        public static void Caller()
        {
            var input = new int[] { 1, 4, 34, 35 ,3 ,50 };            
            Find(input);
        }
        public static void Find(int[] arr)
        {
            var first = int.MinValue;
            var second = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                if (arr[i] > second && arr[i] < first ) 
                {
                    second = arr[i]; 
                }
            }

            Console.WriteLine($"Second Largest: {second}");
        }
    }
}
