using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Write a program to add one to a given number. The use of operators like ‘+’, ‘-‘, ‘*’, ‘/’, ‘++’, ‘–‘ …etc are not allowed. 
    /// </summary>
    class Add1ToANumber
    {
        int x = -2;

        public Add1ToANumber()
        {
            int result = GetResultOfAdding1toANumber();
            Console.WriteLine($"Result of adding 1 to the number {x}, equals {result}");
        }

        public int GetResultOfAdding1toANumber()
        {
            return x | 1; 
        }
    }
}
