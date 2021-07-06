using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms
{
    /// <summary>
    /// You are given n activities with their start and finish times. 
    /// Select the maximum number of activities that can be performed by a single person, 
    /// assuming that a person can only work on a single activity at a time. 
    /// </summary>
    class ActivitySelectionProblem
    {
        // Sorted Activities
        int[] startTime =  { 1, 3, 0, 5, 8, 5 };
        int[] finishTime = { 2, 4, 6, 7, 9, 9 }; // Ans: required index: 0,1,3,4
        

        public ActivitySelectionProblem()
        {
            var listOfIndex = GetResult(startTime, finishTime, startTime.Length);
            Console.WriteLine($"Required indices are: {String.Join(',', listOfIndex)}");
        }

        public List<int> GetResult(int[] s, int[] f, int n)
        {
            List<int> listOfIndex = new List<int>();
            listOfIndex.Add(0);

            int currentFinishTime = f[0];
            for (int i = 1; i < n; i++)
            {
                if (s[i] >= currentFinishTime)
                {
                    listOfIndex.Add(i);
                    currentFinishTime = f[i];                    
                }
            }

            return listOfIndex;
        }

        private void SortByFinishTime()
        {
            //int[] a = { 1, 0, 3 };
            //int[] b = { 2, 6, 4 };

            // Sorts a pair of one-dimensional Array objects
            // (one contains the keys and the other contains the corresponding items)
            // based on the keys in the first Array using the IComparable implementation of each key.
            //Array.Sort(b, a);
            
            //Console.WriteLine($"a: {String.Join(',', a)}");
            //Console.WriteLine($"b: {String.Join(',', b)}");

            Array.Sort(finishTime, startTime);
        }
    }
}
