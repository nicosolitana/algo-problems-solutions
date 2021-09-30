using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algo_problems_solutions.Codility
{
    class _11_PassingCars
    {
        public int GetPairs(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int one = A.Count(x => x == 1);
            int zero = A.Count(x => x == 0);
            int total = 0;
            for (int i = 1; i <= zero; i++)
            {
                total += one;
                one--;
            }
            return total;
        }

        // Time Complexity is O(N^2)
        // Correctness OK
        // Performance NG, Will exceed hard limit
        public int GetPairs2(int[] A)
        {
            int total = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == 1)
                            total++;
                    }
                }
            }
            return total;
        }

        // Time Complexity is O(N)
        // Correctness and Performance OK
        public int GetPairs3(int[] A)
        {
            int zeroCnt = 0;
            int total = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    zeroCnt++;
                }
                else
                {
                    total += zeroCnt;
                }

                if (total > 1000000000)
                    return -1;
            }
            return total;
        }
    }
}
