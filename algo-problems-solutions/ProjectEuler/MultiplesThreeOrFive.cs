using System;
using System.Collections.Generic;
using System.Text;

namespace algo_problems_solutions.ProjectEuler
{
    class MultiplesThreeOrFive
    {
        private static List<int> multiples;
        static int GetSum(int mulp, int sum)
        {
            for (int i = mulp; i < 1000; i = i + mulp)
            {
                if ((i % mulp == 0) && (multiples.IndexOf(i) == -1))
                {
                    sum += i;
                    multiples.Add(i);
                }
            }
            return sum;
        }

        public static void init()
        {
            multiples = new List<int>();
            int sum = GetSum(3, 0);
            sum = GetSum(5, sum);
            string joinVal = string.Join(',', multiples);
            Console.WriteLine("Value of sum is " + sum);
            Console.WriteLine("\n" + joinVal);
            Console.ReadLine();
        }
    }
}
