namespace algo_problems_solutions.Codility
{
    class _02_CyclicRotation
    {
        public int[] solution(int[] A, int K)
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
    }
}
