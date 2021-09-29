using System;

namespace algo_problems_solutions.Codility
{
    class TapeEquilibrium
    {
        public int Add(int[] A, int start)
        {
            int sum = 0;
            for (int i = start; i < A.Length; i++)
            {
                sum += A[i];
            }
            return sum;
        }

        public int solution(int[] A)
        {
            int firstHalf = A[0];
            int diff = -1;
            for (int i = 1; i < A.Length; i++)
            {
                int secondHalf = Add(A, i);
                int new_diff = Math.Abs(firstHalf - secondHalf);
                if (diff == -1)
                    diff = new_diff;

                if (new_diff < diff)
                    diff = new_diff;

                firstHalf += A[i];
            }
            return diff;
        }

        public int solution2(int[] A)
        {
            int allSum = 0;
            for (int i = 0; i < A.Length; i++)
                allSum += A[i];

            int firstHalf = 0;
            int minDiff = int.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                firstHalf += A[i];
                int secondHalf = Math.Abs(allSum - firstHalf);
                int diff = Math.Abs(firstHalf - secondHalf);
                minDiff = Math.Min(minDiff, diff);
            }
            return minDiff;
        }
    }
}
