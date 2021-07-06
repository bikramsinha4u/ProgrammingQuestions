using GreedyAlgorithms.GraphDSNormal;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms
{
    class KruskalsMSTAlgorithm
    {
        int myVertexCount = 4, myEdgeCount = 5;
        int[] mySrc = { 0, 0, 0, 1, 2 };
        int[] myDest = { 1, 2, 3, 3, 3 };
        int[] myWeight = { 10, 6, 5, 15, 4 };
        Graph myGraph;

        public KruskalsMSTAlgorithm()
        {
            myGraph = CreateGraph(myVertexCount, myEdgeCount, mySrc, myDest, myWeight);
            Edge[] resultEdges = KruskalMST(myGraph);
            PrintResultEdges(resultEdges, myVertexCount);
        }

        public Graph CreateGraph(int vertexCount, int edgeCount, int[] src, int[] dest, int[] weight)
        {
            Graph graph = new Graph(vertexCount, edgeCount);

            for (int i = 0; i < edgeCount; i++)
            {
                graph.Edges[i].Src = src[i];
                graph.Edges[i].Dest = dest[i];
                graph.Edges[i].Weight = weight[i];
            }

            return graph;
        }

        public Edge[] KruskalMST(Graph graph)
        {
            int v = graph.V;
            Edge[] resultEdges = new Edge[v-1];
            for (int i = 0; i < v-1; i++)
            {
                resultEdges[i] = new Edge();
            }

            Array.Sort(graph.Edges);

            Subset[] subsets = new Subset[v];
            for (int i = 0; i < v; i++)
            {
                subsets[i] = new Subset() { Parent = i, Rank = 0 };
            }

            int resultEdgeCount = 0;
            int index = 0;
            while (resultEdgeCount < v - 1)
            {
                Edge nextEdge = new Edge();
                nextEdge = graph.Edges[index++];

                int x = FindRootAndMakeParent(subsets, nextEdge.Src);
                int y = FindRootAndMakeParent(subsets, nextEdge.Dest);

                if (x != y)
                {
                    resultEdges[resultEdgeCount++] = nextEdge;
                    Union(subsets, x, y);
                }
            }

            return resultEdges;
        }

        public int FindRootAndMakeParent(Subset[] subsets, int i)
        {
            // find root and make root as
            // parent of i (path compression)
            if (subsets[i].Parent != i)
                subsets[i].Parent = FindRootAndMakeParent(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        // A function that does union of
        // two sets of x and y (uses union by rank)
        public void Union(Subset[] subsets, int x, int y)
        {
            int xroot = FindRootAndMakeParent(subsets, x);
            int yroot = FindRootAndMakeParent(subsets, y);

            // Attach smaller rank tree under root of
            // high rank tree (Union by Rank)
            if (subsets[xroot].Rank < subsets[yroot].Rank)
                subsets[xroot].Parent = yroot;
            else if (subsets[xroot].Rank > subsets[yroot].Rank)
                subsets[yroot].Parent = xroot;

            // If ranks are same, then make one as root
            // and increment its rank by one
            else
            {
                subsets[yroot].Parent = xroot;
                subsets[xroot].Rank++;
            }
        }

        /* OUTPUT
            Following are the edges in the constructed MST
            2 -- 3 == 4
            0 -- 3 == 5
            0 -- 1 == 10
            Minimum Cost Spanning Tree 19
        */
        public void PrintResultEdges(Edge[] results, int v)
        {
            Console.WriteLine("Following are the edges in the constructed MST");

            int minimumCost = 0;
            for (int i = 0; i < v - 1; ++i)
            {
                Console.WriteLine(results[i].Src + " -- " + results[i].Dest + " == " + results[i].Weight);
                minimumCost += results[i].Weight;
            }

            Console.WriteLine("Minimum Cost Spanning Tree " + minimumCost);
        }
    }
}