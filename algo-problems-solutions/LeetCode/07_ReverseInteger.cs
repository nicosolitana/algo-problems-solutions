using System;

namespace algo_problems_solutions.LeetCode
{
    class _07_ReverseInteger
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int Reverse(int x)
        {
            try
            {
                if (x == 0)
                    return 0;

                string reverse = Reverse(x.ToString());
                if (reverse.Contains("-"))
                    reverse = "-" + reverse.Replace('-', ' ');

                return Int32.Parse(reverse);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
