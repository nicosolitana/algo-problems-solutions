using System;

namespace algo_problems_solutions.Codility
{
    class _18_MaxProfit
    {
        // Time Complexity is O(N^2)
        // Might reach hard limit
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0)
                return 0;

            int max = Int32.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    int diff = A[j] - A[i];
                    max = Math.Max(max, diff);
                }
            }
            if (max < 0)
                return 0;

            return max;
        }

        //Time Complexity is O(N)
        public int solution2(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0)
                return 0;

            int minValue = A[0];
            int maxValue = 0;
            for (int i = 1; i < A.Length; i++)
            {
                int max = Math.Max(0, A[i] - minValue);
                minValue = Math.Min(A[i], minValue);
                maxValue = Math.Max(max, maxValue);
            }
            return maxValue;
        }
    }
}
