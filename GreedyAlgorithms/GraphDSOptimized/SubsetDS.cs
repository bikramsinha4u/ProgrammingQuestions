using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms.GraphDSOptimized
{
    class SubsetDS
    {
        public int Parent, Rank;

        public SubsetDS()
        {

        }

        public SubsetDS(int parent, int rank)
        {
            this.Parent = parent;
            this.Rank = rank;
        }
    }
}
