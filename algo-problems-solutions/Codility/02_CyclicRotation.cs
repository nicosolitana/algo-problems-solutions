using System;

namespace algo_problems_solutions.Codility
{
    class _02_CyclicRotation
    {
        public int[] CyclicRotation1(int[] A, int K)
        {
            if ((K == 0) ||
                (A.Length == 1))
                return A;

            int SIZE = A.Length;
            int[] nA = new int[SIZE];

            for (int i = 0; i < SIZE; i++)
            {
                int pos = i + K;
                if (pos >= SIZE)
                {
                    int k_num = K;
                    while (pos >= SIZE)
                    {
                        pos = k_num - (SIZE - i);
                        k_num = pos;
                    }
                }

                nA[pos] = A[i];
            }

            return nA;
        }

        public int[] CyclicRotation2(int[] A, int K)
        {
            if ((K == 0) ||
                (A.Length == 1) ||
                (A.Length == 0) ||
                (K % A.Length == 0))
                    return A;

            while (K > A.Length)
            {
                K = K - A.Length;
            }

            int count = A.Length - K;
            int c_count = A.Length - count;

            int[] B = new int[A.Length];
            Array.Copy(A, 0, B, A.Length - count, count);
            Array.Copy(A, A.Length - c_count, B, 0, c_count);
            return B;
        }
    }
}
