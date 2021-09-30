using System;
using System.Linq;

namespace algo_problems_solutions.Codility
{
    class _07_FrogRiverOne
    {
        // O(N)
        public int GetSoln1(int X, int[] A)
        {
            int[] B = A.Distinct().ToArray();
            return (B.Length != X) ? -1 : Array.IndexOf<int>(A, B[B.Length - 1]);
        }
    }
}
