using System;

namespace algo_problems_solutions.ProjectEuler
{
    class SumOfPrimesBelow2M
    {
        private static bool[] SieveOfEratosthenes(int size)
        {
            bool[] arr = new bool[size];
            int sqrtValue = Convert.ToInt32(Math.Round(Math.Sqrt(size),
                               MidpointRounding.AwayFromZero));

            for (int i = 2; i < sqrtValue; i++)
            {
                if (arr[i] == false)
                {
                    int m = 0;
                    for (int j = i * i; j < size; j = i * i + m * i)
                    {
                        m++;
                        arr[j] = true;
                    }
                }
            }
            return arr;
        }


        private static double GetSum(int n)
        {
            double sum = 0;
            bool[] arr = SieveOfEratosthenes(n);
            for (int i = 2; i < n; i++)
            {
                if (arr[i] == false)
                    sum += i;
            }
            return sum;
        }


        public static void init()
        {
            Console.WriteLine("[1] Sum of all prime below 2M is " + GetSum(2000000));
            Console.ReadLine();
        }
    }
}
