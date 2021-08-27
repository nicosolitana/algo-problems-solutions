using System;
using System.Numerics;

namespace algo_problems_solutions.ProjectEuler
{
    class FactorialDigitSum
    {
        private static int GetSum()
        {
            BigInteger bi = new BigInteger();
            bi = 1;
            int i = 100;
            while (i >= 1)
            {
                bi *= i;
                i--;
            }

            int sum = 0;
            while (bi > 0)
            {
                sum += (int)(bi % 10);
                bi /= 10;
            }
            return sum;
        }

        public static void init()
        {
            Console.WriteLine("Sum is " + GetSum());
            Console.ReadLine();
        }
    }
}
