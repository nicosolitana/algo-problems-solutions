using System;
using System.Collections.Generic;

namespace algo_problems_solutions.ProjectEuler
{
    class LargestPrimeFactor
    {
        private static List<double> PrimeLst = new List<double>();

        private static double GetDivisible(double value)
        {
            double div = 2;
            while (true)
            {
                if (value % div == 0)
                    return div;

                div++;
                if (div >= value)
                    break;
            }
            return div;
        }

        private static double GetLargestFactor()
        {
            double largest = 2;
            //double value = 13195;
            double value = 600851475143;
            while (true)
            {
                double div = GetDivisible(value);
                value = value / div;

                if (div > largest)
                    largest = div;

                if (value == 1)
                    break;
            }
            return largest;
        }


        public static void init()
        {
            PrimeLst.Add(2);
            Console.WriteLine("Largest prime value is " + GetLargestFactor());
            Console.ReadLine();
        }
    }
}
