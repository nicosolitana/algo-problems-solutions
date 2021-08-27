using System;

namespace algo_problems_solutions.ProjectEuler
{
    class FiboBelow4M
    {
        private static int Fibonacci()
        {
            int i = 2, fiboOld = 1;
            int sum = 2;
            Console.WriteLine(fiboOld + ", " + i);
            while (true)
            {
                int fiboN = fiboOld + i;
                if (fiboN > 4000000)
                    break;

                if (fiboN % 2 == 0)
                    sum += fiboN;
                fiboOld = i;
                i = fiboN;
            }
            return sum;
        }

        public static void init()
        {
            Console.WriteLine("Sum of all even values is " + Fibonacci());
            Console.ReadLine();
        }
    }
}
