using GreedyAlgorithms.GraphDSNormal;
using System;

namespace GreedyAlgorithms
{
    class StartupProgram
    {
        static void Main(string[] args)
        {
            //ActivitySelectionProblem activitySelectionProblem = new ActivitySelectionProblem();
            //KruskalsMSTalgorithm kruskalsMSTalgorithm = new KruskalsMSTalgorithm();

            #region Disjoint Union Set
            int n = 5;
            DisjointUnionSets disjointUnionSets = new DisjointUnionSets(n);

            // make relations
            disjointUnionSets.Union(0, 2); // 0 is a friend of 2
            disjointUnionSets.Union(4, 2); // 4 is a friend of 2
            disjointUnionSets.Union(3, 1); // 3 is a friend of 1

            if (disjointUnionSets.Find(4) == disjointUnionSets.Find(0)) // Check if 4 is a friend of 0
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            if (disjointUnionSets.Find(1) == disjointUnionSets.Find(0)) // Check if 1 is a friend of 0
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion

            #region Program to detect cycle in a graph
            GraphDSOptimized.GraphDS graph = new GraphDSOptimized.GraphDS(3, 3);

            // Add edge 0-1
            graph.Edges[0].Src = 0;
            graph.Edges[0].Dest = 1;

            // Add edge 1-2
            graph.Edges[1].Src = 1;
            graph.Edges[1].Dest = 2;

            // Add edge 0-2
            graph.Edges[2].Src = 0;
            graph.Edges[2].Dest = 2;

            Console.WriteLine(graph.HasCycle() ? "Graph contains cycle." : "Graph doesn't contain cycle.");
            #endregion

            #region Kruskal MST Optimized
            KrushkalMSTAlgorithmOptimized krushkalMSTAlgorithmOptimized = new KrushkalMSTAlgorithmOptimized();
            var resultMST = krushkalMSTAlgorithmOptimized.KruskalMST();
            krushkalMSTAlgorithmOptimized.PrintMSTResult(resultMST);
            #endregion
        }
    }
}