using System;
using System.Linq;

namespace algo_problems_solutions.Codility
{
    class _05_PermElem
    {
        public int solution(int[] A)
        {
            int n = A.Length + 1;
            int perm = (n * (n + 1)) / 2;
            return perm - A.Sum();
        }

        public int solution1(int[] A)
        {
            if (A.Length == 0)
                return 1;

            Array.Sort(A);
            int count = 0;
            bool IsChange = false;
            for (int i = 0; i < A.Length; i++)
            {
                count++;
                if (A[i] != count)
                {
                    IsChange = true;
                    break;
                }
            }

            if (IsChange == false)
                count++;
            return count;
        }
    }
}
