using System;

namespace algo_problems_solutions.ProjectEuler
{
    class LargestPalindromeProduct
    {
        private static string Reverse(string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static int GetPalindromeProduct(int n)
        {
            int upperLimit = Convert.ToInt32(Math.Pow(10, n));
            int lowerLimit = 1 + upperLimit / 10;
            int max = 0;
            for (int i = upperLimit; i >= lowerLimit; i--)
            {
                for (int j = i; j >= lowerLimit; j--)
                {
                    int product = i * j;
                    if (product < max)
                        break;

                    if (product.ToString() == Reverse(product.ToString()))
                    {
                        max = product;
                    }
                }
            }

            return max;
        }

        public static void init()
        {
            Console.WriteLine("Largest prime value is " + GetPalindromeProduct(3));
            Console.ReadLine();
        }
    }
}
