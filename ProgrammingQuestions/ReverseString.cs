using System;

namespace ProgrammingQuestions
{
    internal class ReverseString
    {
        public static void Caller()
        {
            var input = "Geeks for GeeksProblem";
            Reverse(input.ToCharArray());
            ReverseWordByWord(input);
            ReverseWordByWord2(input);
            ReverseEachWord(input);
        }

        public static void Reverse(char[] arr)
        {
            var size = arr.Length;
            Console.WriteLine($"Input string is: {string.Join("", arr)}");

            for (int i = 0, j = size - 1; i < size && i < j; i++, j--)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            Console.WriteLine($"String revered is: {string.Join("", arr)}");
        }

        public static void ReverseWordByWord(string str)
        {
            Console.WriteLine($"Input string is: {str}");

            var stringArr = str.Split(" ");
            Array.Reverse(stringArr);
            var result = string.Join(" ", stringArr);

            Console.WriteLine($"String revered word by word is: {result}");
        }

        public static void ReverseWordByWord2(string str)
        {
            Console.WriteLine($"Input string is: {str}");

            Console.Write($"String revered word by word is: ");
            var stringArr = str.Split(" ");
            for (int i = stringArr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{stringArr[i]}{(i == 0 ? string.Empty : " ")}");
            }

            Console.WriteLine();
        }

        public static void ReverseEachWord(string str)
        {
            Console.WriteLine($"Input string is: {str}");

            var charArr = str.ToCharArray();
            var size = charArr.Length;

            var start = size - 1;
            var end = size - 1;
            for (int i = size - 1; i >= 0; i--)
            {
                if (charArr[i] == ' ' || i == 0)
                {
                    if (i == 0)
                        start = i;
                    else
                        start = i + 1;
                    reverse(charArr, start, end);
                    end = i - 1;
                }
            }

            Console.WriteLine($"Each word is reversed: {string.Join("", charArr)}");
        }

        public static void reverse(char[] arr, int startIndex, int endIndex)
        {
            for (int i = startIndex, j = endIndex; i < j; i++, j--)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
