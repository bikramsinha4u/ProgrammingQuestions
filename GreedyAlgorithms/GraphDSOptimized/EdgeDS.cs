using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms.GraphDSOptimized
{
    class EdgeDS : IComparable<EdgeDS>
    {
        public int Src, Dest, Weight;

        public int CompareTo(EdgeDS other)
        {
            return this.Weight - other.Weight;
        }
    }
}
