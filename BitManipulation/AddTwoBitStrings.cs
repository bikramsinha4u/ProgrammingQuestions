using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class AddTwoBitStrings
    {
        string x = "1100011", y = "10"; // result 1100101

        public AddTwoBitStrings()
        {
            string result = GetResult(x, y);
            Console.WriteLine($"Result is: {result}");
        }

        public string GetResult(string x, string y)
        {
            int xLength = x.Length - 1;
            int yLength = y.Length - 1;
            string result = "";

            int carry = 0;
            while (xLength >= 0 || yLength >= 0)
            {
                int xBit = 0, yBit = 0;
                if (xLength >= 0)
                {
                    xBit = x[xLength] - '0';
                }

                if (yLength >= 0)
                {
                    yBit = y[yLength] - '0';
                }

                xLength--; yLength--;

                int temp = xBit + yBit + carry;
                carry = temp >= 2 ? 1 : 0;

                result = (temp % 2) + result;
            }

            if (carry == 1)
            {
                return "1" + result;
            }

            return result;
        }
    }
}
