using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms.GraphDSNormal
{
    class Graph
    {
        public int V, E;
        public Edge[] Edges;

        public Graph(int numberOfVertices, int numberOfEdges)
        {
            V = numberOfVertices; E = numberOfEdges;

            Edges = new Edge[numberOfEdges];
            for (int i = 0; i < numberOfEdges; i++)
            {
                Edges[i] = new Edge();
            }
        }

        /// <summary>
        /// A utility function to find set of an element i (not uses path compression technique)
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int FindRoot(int[] parent, int i)
        {
            if (parent[i] == -1)
                return i;

            return FindRoot(parent, parent[i]);
        }

        /// <summary>
        /// A function that does union of two sets of x and y (not uses union by rank)
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PerformUnion(int[] parent, int x, int y)
        {
            parent[x] = y;
        }

        public bool FindIfCycle(Graph graph)
        {
            int[] parent = new int[graph.V];

            for (int i = 0; i < graph.V; ++i)
                parent[i] = -1;

            for (int i = 0; i < graph.E; ++i)
            {
                int x = graph.FindRoot(parent,
                                   graph.Edges[i].Src);
                int y = graph.FindRoot(parent,
                                   graph.Edges[i].Dest);

                if (x == y)
                    return true;

                graph.PerformUnion(parent, x, y);
            }

            return false;
        }
    }
}
