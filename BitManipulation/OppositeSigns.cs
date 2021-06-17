using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// Detect if two integers have opposite signs
    /// </summary>
    class OppositeSigns
    {
        private const int x = 2;
        private const int y = -2;

        public bool GetOppositeSignsUsingBitwiseAND()
        {
            if (x == 0 && y == 0)
            {
                return false;
            }
            else
                return (x & y) >= 0;
        }

        public bool GetOppositeSignsUsingBitwiseXOR()
        {
            return (x ^ y) < 0;
        }
    }
}
