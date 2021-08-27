using System;
using System.Numerics;

namespace algo_problems_solutions.ProjectEuler
{
    class SelfPowers
    {
        private static string GetLastTenDigits()
        {
            BigInteger bi = new BigInteger();
            BigInteger sum = new BigInteger();
            for (int i = 1; i <= 1000; i++)
            {
                bi = (BigInteger)Math.Pow(i, i);
                sum += bi;
            }
            int length = sum.ToString().Length;
            return sum.ToString().Substring(length - 10, 10);
        }

        public static void init()
        {
            Console.WriteLine("Sum is " + GetLastTenDigits());
            Console.ReadLine();
        }
    }
}
