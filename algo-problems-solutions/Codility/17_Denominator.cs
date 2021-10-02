using System;
using System.Linq;

namespace algo_problems_solutions.Codility
{
    class _17_Denominator
    {
        // Time Complexity is O(N^2)
        // Correctness OK, Performance NG. Can reach hard limit
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0)
                return -1;

            if (A.Length == 1)
                return 0;

            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A.Where(x => x.Equals(A[i])).Count();
            }
            int index = Array.IndexOf(B, B.Max());

            if (B[index] > (A.Length / 2))
            {
                return index;
            }
            return -1;
        }

        // Time Complexity is O(N) but can also reach 
        // O(N log N)
        public int solution2(int[] A)
        {
            if (A.Length == 0)
                return -1;

            if (A.Length == 1)
                return 0;

            var value = (from item in A
                         group item by item into g
                         orderby g.Count() descending
                         select g.Key).First();

            int count = A.Where(x => x.Equals(value)).Count();
            int index = Array.IndexOf(A, value);

            if (count > (A.Length / 2))
            {
                return index;
            }
            return -1;
        }
    }
}
