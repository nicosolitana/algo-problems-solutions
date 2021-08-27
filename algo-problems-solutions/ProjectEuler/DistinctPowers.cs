using System;
using System.Collections.Generic;
using System.Numerics;

namespace algo_problems_solutions.ProjectEuler
{
    class DistinctPowers
    {
        private static int CountDistinctPowers()
        {
            List<BigInteger> biLst = new List<BigInteger>();
            BigInteger biVal = new BigInteger();
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    biVal = (BigInteger)Math.Pow(i, j);
                    if (biLst.IndexOf(biVal) == -1)
                        biLst.Add(biVal);
                }
            }
            return biLst.Count;
        }

        public static void init()
        {
            Console.WriteLine("Sum is " + CountDistinctPowers());
            Console.ReadLine();
        }
    }
}
