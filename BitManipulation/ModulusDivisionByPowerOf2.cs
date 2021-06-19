using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Compute n modulo d without division(/) and modulo(%) operators, where d is a power of 2 number. 
    /// </summary>
    class ModulusDivisionByPowerOf2
    {
        int n = 6;
        int d = 4;

        public ModulusDivisionByPowerOf2()
        {
            int result = GetResult(n, d);
            Console.WriteLine($"{n} mod {d} is {result}");
        }

        public int GetResult(int n, int d)
        {
            return n & (d - 1);
        }
    }
}
