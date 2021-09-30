namespace algo_problems_solutions.Codility
{
    class _12_CountDiv
    {
        // Time Complexity O(B-A)
        // Correctness OK
        // Performance NG, Might exceed hard limit on large inputs
        public int solution(int A, int B, int K)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                    count++;
            }
            return count;
        }

        // Time Complexity O(1)
        public int solution2(int A, int B, int K)
        {
            if (A % K == 0)
                return (B / K) - (A / K) + 1;

            return (B / K) - (A / K);
        }
    }
}
