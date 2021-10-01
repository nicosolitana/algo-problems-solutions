using System;
using System.Collections.Generic;
using System.Text;

namespace algo_problems_solutions.Codility
{
    class _13_GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            int[] minValueLst = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                int min;
                String sub = S.Substring(P[i], (Q[i] - P[i]) + 1);
                if (sub.Contains("A"))
                    min = 1;
                else if (sub.Contains("C"))
                    min = 2;
                else if (sub.Contains("G"))
                    min = 3;
                else
                    min = 4;
                minValueLst[i] = min;
            }
            return minValueLst;
        }

        private int GetVal(char c)
        {
            switch (c)
            {
                case 'A': return 0;
                case 'C': return 1;
                case 'G': return 2;
                default: return 3;
            }
        }
        public int[] solution2(string S, int[] P, int[] Q)
        {
            var counts = new int[4, S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                var val = GetVal(S[i]);
                for (int j = 0; j < 4; j++)
                    counts[j, i] = (j == val ? 1 : 0) + (i == 0 ? 0 : counts[j, i - 1]);
            }
            var result = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                var p = P[i];
                var q = Q[i];
                for (int j = 0; j < 4; j++)
                {
                    if (counts[j, q] - (p == 0 ? 0 : counts[j, p - 1]) > 0)
                    {
                        result[i] = j + 1;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
