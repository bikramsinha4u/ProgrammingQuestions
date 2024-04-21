using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace InterviewQuestions
{
    class ReverseStringWordByWord
    {
        public static char[] SampleInput()
        {
            var input = "My name is John ".ToCharArray();

            return input;
        }

        public static void GetOutput()
        {
            var output = ReverseWords(SampleInput());
            Console.WriteLine(output);
        }

        public static char[] ReverseWords(char[] input)
        {
            string result = "";

            int endIndex = input.Length - 1;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int startIndex = i;
                if (input[i] == ' ' || i == 0)
                {
                    if (i == 0)
                        startIndex = i;
                    else
                        startIndex = i + 1;

                    for (int j = startIndex; j <= endIndex; j++)
                    {
                        result += input[j];
                    }

                    result += " ";
                    endIndex = i - 1;
                }

            }

            return result.ToCharArray();
        }

        public static void ReverseWords()
        {
            string input = "My name is John";

            string[] inputArr = input.Split(" ");
            //var list = inputArr.Reverse();
            //Array.Reverse(inputArr);

            Console.WriteLine(string.Join(" ", inputArr.Reverse()));
            //Console.WriteLine(string.Join(" ", input.Split(' ').Reverse()));
        }
        
        public static void ReverseWords2()
        {
            string[] s = "My name is John".Split(' ');
            string ans = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }

            Console.Write(ans);
        }

        /*
         * By this approach, we can even remove extra trailing spaces and in between the words also.
         *   Basically, this algorithm involves 3 steps.
         *
         *   If you find white space, there can be two possibilities. 
         *   It might be end of a word or else extra trailing space in between the words.
         *   if it is not a white space, add the character to temporary word as shown in the below
        */
        public static string ReverseString(string s)
        {
            var ans = new System.Text.StringBuilder();

            var temp = "";
            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch == ' ')
                {
                    //if we find white space add temp in the start
                    if (!temp.Equals(""))
                    {
                        //adding in the front every time
                        ans.Insert(0, temp + " ");
                    }

                    temp = "";
                }
                else
                    temp += ch;
            }

            //just removing the extra space at the end of the ans
            return ans.ToString().Substring(0, ans.Length - 1);
        }

    }
}
