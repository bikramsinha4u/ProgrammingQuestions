using System;
using System.Collections.Generic;

namespace ProgrammingQuestions
{
    internal class FirstNonRepeatingChar
    {
        public static void FirstNonRepeatingCharacter1(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {

                if (s.IndexOf(s[i], i + 1) == -1)
                {
                    Console.WriteLine("1. First non-repeating character is "+ s[i]);
                    break;
                }
            }
            return;
        }

        static char FirstNonRepeatingCharacter2(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (str.IndexOf(c) == str.LastIndexOf(c))
                {
                    Console.WriteLine("2. First non-repeating character is "+ c);
                    return c;
                }
            }

            return '\0'; // Return null character if no non-repeating character is found
        }

        static char FirstNonRepeatingCharacter3(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count the occurrences of each character
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the first non-repeating character
            foreach (char c in str)
            {
                if (charCount[c] == 1)
                {
                    Console.WriteLine("3. First non-repeating character is " + c);
                    return c;
                }
            }

            return '\0'; // Return null character if no non-repeating character is found
        }


        internal static void Caller()
        {
            string s = "geeksforgeeks";
            FirstNonRepeatingCharacter1(s);
            FirstNonRepeatingCharacter2(s);
            FirstNonRepeatingCharacter3(s);
        }
    }
}
