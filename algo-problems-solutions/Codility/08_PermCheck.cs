using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algo_problems_solutions.Codility
{
    class _08_PermCheck
    {
        // Time Complexity O(N)
        public int Soln1(int[] A)
        {
            int[] B = A.Distinct().ToArray();

            if (B.Length != A.Length)
                return 0;

            Array.Sort(B);
            int max = B.Max();

            for (int i = 0; i < max; i++)
            {
                if (B[i] != (i + 1))
                    return 0;
            }
            return 1;
        }

        // Might not work on very large inputs 
        // since long perm and sum might encounter number overflow
        public int Soln2(int[] A)
        {
            int[] B = A.Distinct().ToArray();

            if (B.Length != A.Length)
                return 0;

            int max = B.Max();
            long perm = (max * (max + 1)) / 2;
            long sum = B.Sum();

            return perm == sum? 1 : 0;
        }
    }
}
