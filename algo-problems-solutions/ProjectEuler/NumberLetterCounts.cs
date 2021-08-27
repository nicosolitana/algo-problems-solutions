using Humanizer;
using System;

namespace algo_problems_solutions.ProjectEuler
{
    class NumberLetterCounts
    {
        private static double LetterCounter()
        {
            double sum = 0;
            int i = 1;
            while (i <= 1000)
            {
                sum += i.ToWords().Replace(" ", String.Empty).Replace("-", String.Empty).Length;
                i++;
            }
            return sum;
        }

        public static void init()
        {
            Console.WriteLine("Total Letter Coount is " + LetterCounter());
            Console.ReadLine();
        }
    }
}
