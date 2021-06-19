using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    class RotateBitsOfNumber
    {
        int n = 3;
        int d = 1;
        int BitStoredUsed = 32;

        public RotateBitsOfNumber()
        {
            int result = GetLeftShiftRotationResult(n, d);
            Console.WriteLine($"Result after left shift rotation : {result}");

            int result2 = GetRightShiftRotationResult(n, d);
            Console.WriteLine($"Result after right shift rotation : {result2}");
        }

        public int GetLeftShiftRotationResult(int n, int d)
        {
            return (n << d) | (n >> (BitStoredUsed - d));
        }

        public int GetRightShiftRotationResult(int n, int d)
        {
            return (n >> d) | (n << (BitStoredUsed - d));
        }
    }
}
