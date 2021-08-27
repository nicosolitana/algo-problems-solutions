using System;
using System.Collections.Generic;
using System.Text;

namespace algo_problems_solutions.ProjectEuler
{
    class SmallestMultiple
    {
        // Can reduce checking to 7,11,12,13,14,15,16,17,18,19,20
        private static bool IsVisible(int value)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (value % i != 0)
                    return false;
            }
            return true;
        }

        public static int GetSmallestPositive()
        {
            int value = 2520;
            while (true)
            {
                if (IsVisible(value))
                    break;
                value++;
            }
            return value;
        }

        public static void init()
        {
            Console.WriteLine("Smallest positive value multiple of 1 to 20 is " + GetSmallestPositive());
            Console.ReadLine();
        }
    }
}
