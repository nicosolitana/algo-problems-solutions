using System;

namespace algo_problems_solutions.Codility
{
    class _15_MaxProductOfThree
    {
        public int GetMax(int[] A)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    for (int k = 0; k < A.Length; k++)
                    {
                        if ((i != j) && (i != k) && (j != k))
                        {
                            int prod = A[i] * A[j] * A[k];
                            max = Math.Max(max, prod);
                        }
                    }
                }
            }
            return max;
        }

        // Time Complexity of O(N * log N)
        public int solution(int[] A)
        {
            Array.Sort(A);

            int SIZE = 6;
            if (A.Length < 6)
                SIZE = A.Length;

            int[] B = new int[SIZE];
            Array.Copy(A, 0, B, 0, 3);
            if (A.Length > 6)
                Array.Copy(A, A.Length - 3, B, 3, 3);
            else
                Array.Copy(A, 3, B, 3, A.Length - 3);

            return GetMax(B);
        }
    }
}
