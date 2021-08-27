using System;
using System.Numerics;

namespace algo_problems_solutions.ProjectEuler
{
    class Fibo1000
    {
        private static int Fibonacci()
        {
            BigInteger bii = new BigInteger();
            BigInteger bifiboOld = new BigInteger();
            BigInteger bifiboN = new BigInteger();
            bii = 2;
            bifiboOld = 1;
            int i = 3;
            while (true)
            {
                bifiboN = bifiboOld + bii;
                i++;
                if (bifiboN.ToString().Length == 1000)
                    break;
                bifiboOld = bii;
                bii = bifiboN;
            }
            return i;
        }

        public static void init()
        {
            Console.WriteLine("Sum is " + Fibonacci());
            Console.ReadLine();
        }
    }
}
