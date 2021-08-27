using System;
using System.Numerics;

namespace algo_problems_solutions.ProjectEuler
{
    class PowerDigitSum
    {
        private static double GetPowerDigitSum()
        {
            double sum = 0;
            BigInteger powValue = BigInteger.Pow(2, 1000);

            while (powValue > 0)
            {
                sum += (int)(powValue % 10);
                powValue /= 10;
            }
            return sum;
        }

        public static void init()
        {
            Console.WriteLine("First Ten Digits are " + GetPowerDigitSum());
            Console.ReadLine();
        }
    }
}
