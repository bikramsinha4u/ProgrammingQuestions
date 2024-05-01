using System;
using System.Collections.Generic;

namespace ProgrammingQuestions
{
    public class BalancedBrackets
    {
        public static void Caller()
        {
            var str = "[()]{}{()()}";
            Balanced(str);
        }
        public static void Balanced(string str)
        {
            var stack = new Stack<char>();
            var balanced = true;
            var temp = ' ';

            foreach (var item in str)
            {
                if (item == '{' || item == '[' || item == '(')
                {
                    stack.Push(item);
                }
                if (item == '}' || item == ']' || item == ')')
                {
                    if (stack.Count == 0)
                    {
                        balanced = false;
                        break;
                    }
                    temp = stack.Pop();
                    if (IsMatchingClosingBracket(item, temp))
                        continue;
                    else
                    {
                        balanced = false;
                        break;
                    }
                }
            }

            if (stack.Count == 0 && balanced == true)
                Console.WriteLine("Brackets are balanced");
            else
                Console.WriteLine("Brackets are not balanced");
        }

        public static bool IsMatchingClosingBracket(char item, char temp)
        {
            if (item == '}' && temp == '{')
                return true;
            if (item == ']' && temp == '[')
                return true;
            if (item == ')' && temp == '(')
                return true;

            return false;
        }
    }
}
