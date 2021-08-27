using System;
using System.Collections.Generic;

namespace algo_problems_solutions.ProjectEuler
{
    class _10001stPrime
    {
        private static List<int> PrimeList = new List<int>();

        private static bool IsPrime(int value)
        {
            if (value > 1)
            {
                for (int i = 2; i < value; i++)
                {
                    if ((value % i) == 0)
                        return false;
                }
            }
            return true;
        }
        private static int GetNthPrime()
        {
            int i = 2;
            while (true)
            {
                if (IsPrime(i))
                {
                    PrimeList.Add(i);
                }
                i++;
                if (PrimeList.Count == 10001)
                    break;
            }
            return PrimeList[PrimeList.Count - 1];
        }

        public static void init()
        {
            Console.WriteLine("10001st Prime is " + GetNthPrime());
            Console.ReadLine();
        }
    }
}
