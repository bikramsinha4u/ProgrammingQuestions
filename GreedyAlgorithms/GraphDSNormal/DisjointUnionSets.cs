using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms.GraphDSNormal
{
    class DisjointUnionSets
    {
        int[] rank;
        int[] parent;
        int n;

        public DisjointUnionSets(int n)
        {
            rank = new int[n];
            parent = new int[n];
            this.n = n;
            MakeSet();
        }

        public void MakeSet()
        {
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }
        }

        /// <summary>
        /// A utility function to find set of an element i, (uses path compression technique)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Find(int x)
        {
            if (parent[x] != x)
            {
                parent[x] = Find(parent[x]);
            }

            return parent[x];
        }

        /// <summary>
        /// A function that does union of two sets of x and y, (uses union by rank)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Union(int x, int y)
        {
            int xRoot = Find(x);
            int yRoot = Find(y);

            if (xRoot == yRoot)
            {
                return;
            }

            if (rank[xRoot] < rank[yRoot])
            {
                parent[xRoot] = yRoot;
            }
            else if (rank[yRoot] < rank[xRoot])
            {
                parent[yRoot] = xRoot;
            }
            else
            {
                parent[yRoot] = xRoot;
                rank[xRoot] = rank[xRoot] + 1;
            }
        }
    }
}
