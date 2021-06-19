using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class BinaryRepresentationOfNumber
    {
        int n = 2;

        public BinaryRepresentationOfNumber()
        {
            string result = GetResult(n);
            Console.WriteLine($"Binary representation of {n} is: {result}");
        }

        public string GetResult(int n)
        {
            string result = "";
            while (n > 0)
            {
                result = (n & 1).ToString() + result;
                n = n >> 1;
            }

            return result;
        }
    }
}
