using System;
using System.Linq;

namespace algo_problems_solutions.Codility
{
    class _10_MissingInteger
    {
        // Time Complexity is O(N)
        public int GetMissingInteger(int[] A)
        {
            int[] B = A.Distinct().ToArray();
            Array.Sort(B);

            int smallest = 1;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == smallest)
                    smallest++;
            }
            return smallest;
        }
    }
}
