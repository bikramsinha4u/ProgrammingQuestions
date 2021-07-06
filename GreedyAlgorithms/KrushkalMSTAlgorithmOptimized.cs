using GreedyAlgorithms.GraphDSOptimized;
using System;

namespace GreedyAlgorithms
{
    class KrushkalMSTAlgorithmOptimized
    {
        GraphDS myGraph = new GraphDS(4, 5);

        public KrushkalMSTAlgorithmOptimized()
        {
            ConstructGraphInput();
        }

        public EdgeDS[] KruskalMST()
        {
            // This will store the resultant MST
            EdgeDS[] mstEdges = new EdgeDS[myGraph.V - 1];
            for (int i = 0; i < myGraph.V - 1; i++)
            {
                mstEdges[0] = new EdgeDS();
            }

            // Step 1: Sort all the edges in non-decreasing order of their weight.
            // If we are not allowed to change the given graph, we can create a copy of array of edges.
            Array.Sort(myGraph.Edges);

            // Step 2: Allocate memory for creating V ssubsets
            SubsetDS[] subsets = new SubsetDS[myGraph.V];
            for (int i = 0; i < myGraph.V; i++)
            {
                subsets[i] = new SubsetDS(i, 0);
            }

            // Step 3: Number of Edges to be taken is V - 1
            int edgesCounter = 0;
            int nERequired = 0;
            while (nERequired < myGraph.V - 1)
            {
                // Step 4: Pick the smallest edge. And increment the index for next iteration
                EdgeDS edge = new EdgeDS();
                edge = myGraph.Edges[edgesCounter++];

                int xRoot = myGraph.FindRoot(subsets, edge.Src);
                int yRoot = myGraph.FindRoot(subsets, edge.Dest);

                // Step 5: If including this edge does't cause cycle, include it in result and increment the index of result for next edge
                if (xRoot != yRoot)
                {
                    mstEdges[nERequired++] = edge;
                    myGraph.DoUnion(subsets, xRoot, yRoot);
                }
            }

            return mstEdges;
        }

        /* Output:
         *  Following are the edges in the constructed MST
         *  2 -- 3 == 4
         *  0 -- 3 == 5
         *  0 -- 1 == 10
         *  Minimum Cost Spanning Tree: 19
         */
        public void PrintMSTResult(EdgeDS[] mstEdges)
        {
            Console.WriteLine("Following are the edges in the constructed MST");

            int minimumCost = 0;
            for (int i = 0; i < mstEdges.Length; i++)
            {
                Console.WriteLine(mstEdges[i].Src + " -- " + mstEdges[i].Dest + " == " + mstEdges[i].Weight);
                minimumCost += mstEdges[i].Weight;
            }

            Console.WriteLine("Minimum Cost of the Spanning Tree: " + minimumCost);
        }

        private void ConstructGraphInput()
        {
            myGraph.Edges[0].Src = 0;
            myGraph.Edges[0].Dest = 1;
            myGraph.Edges[0].Weight = 10;

            myGraph.Edges[1].Src = 0;
            myGraph.Edges[1].Dest = 2;
            myGraph.Edges[1].Weight = 6;

            myGraph.Edges[2].Src = 0;
            myGraph.Edges[2].Dest = 3;
            myGraph.Edges[2].Weight = 5;

            myGraph.Edges[3].Src = 1;
            myGraph.Edges[3].Dest = 3;
            myGraph.Edges[3].Weight = 15;

            myGraph.Edges[4].Src = 2;
            myGraph.Edges[4].Dest = 3;
            myGraph.Edges[4].Weight = 4;
        }
    }
}
