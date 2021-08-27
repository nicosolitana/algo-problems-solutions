using System;

namespace algo_problems_solutions.ProjectEuler
{
    class SumSquareDifference
    {
        private static int GetSumSquare(int n)
        {
            int sumSquare = n * (n + 1) * (2 * n + 1) / 6;
            int squareSum = ((n * (n + 1)) / 2) * ((n * (n + 1)) / 2);
            return squareSum - sumSquare;
        }

        public static void init()
        {
            Console.WriteLine("Smallest positive value multiple of 1 to 20 is " + GetSumSquare(100));
            Console.ReadLine();
        }
    }
}
