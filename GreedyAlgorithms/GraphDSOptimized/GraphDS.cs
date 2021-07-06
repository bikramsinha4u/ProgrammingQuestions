namespace GreedyAlgorithms.GraphDSOptimized
{
    class GraphDS
    {
        public int V, E;
        public EdgeDS[] Edges;

        public GraphDS(int nV, int nE)
        {
            this.V = nV;
            this.E = nE;
            Edges = new EdgeDS[E];

            for (int i = 0; i < E; i++)
            {
                Edges[i] = new EdgeDS();
            }
        }

        // A utility function to find set of an element i (uses path compression technique)
        public int FindRoot(SubsetDS[] subsets, int i)
        {
            if (subsets[i].Parent != i)
            {
                subsets[i].Parent = FindRoot(subsets, subsets[i].Parent);
            }

            return subsets[i].Parent;
        }

        // A function that does union of two sets of x and y (uses union by rank)
        public void DoUnion(SubsetDS[] subsets, int x , int y)
        {
            int xRoot = x;// FindSet(subsets, x);
            int yRoot = y;// FindSet(subsets, y);

            if (subsets[xRoot].Rank < subsets[yRoot].Rank)
            {
                subsets[xRoot].Parent = yRoot;
            }
            else if (subsets[yRoot].Rank < subsets[xRoot].Rank)
            {
                subsets[yRoot].Parent = xRoot;
            }
            else
            {
                subsets[yRoot].Parent = xRoot;
                subsets[xRoot].Rank++;
            }
        } 

        public bool HasCycle()
        {
            SubsetDS[] subsets = new SubsetDS[this.V];
            for (int i = 0; i < this.V; i++)
            {
                subsets[i] = new SubsetDS(i, 0);
            }

            for (int i = 0; i < this.E; i++)
            {
                int xRoot = FindRoot(subsets, this.Edges[i].Src);
                int yRoot = FindRoot(subsets, this.Edges[i].Dest);
                if (xRoot == yRoot)
                {
                    return true;
                }
                DoUnion(subsets, xRoot, yRoot);
            }

            return false;
        }
    }
}
