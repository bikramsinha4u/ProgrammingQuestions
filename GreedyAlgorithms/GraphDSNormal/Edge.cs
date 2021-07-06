using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GreedyAlgorithms.GraphDSNormal
{
    class Edge : IComparable<Edge>
    {
        public int Src, Dest, Weight;

        public int CompareTo(Edge other)
        {
            return this.Weight - other.Weight;
        }
    }
}
