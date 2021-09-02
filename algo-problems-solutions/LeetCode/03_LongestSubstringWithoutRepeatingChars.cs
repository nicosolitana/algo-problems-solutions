using System;

namespace algo_problems_solutions.LeetCode
{

    // NOT YET DONE
    class _03_LongestSubstringWithoutRepeatingChars
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int length;
            int maxLength = 0;
            string str;

            char[] input = s.ToCharArray();

            for (int i=0; i< s.Length; i++)
            {
                length = 0;
                str = string.Empty;
                for (int j = i; j < s.Length; j++)
                {
                    if (!str.Contains(input[j]))
                    {
                        length++;
                        str += input[j].ToString();
                    } else
                    {
                        length = 1;
                        str = input[j].ToString();
                    }

                    if (maxLength < length)
                        maxLength = length;
                }
            }
            return maxLength;
        }

        public static void init()
        {
            //int length = LengthOfLongestSubstring("pwwkew");
            int length = LengthOfLongestSubstring("dvdf");
            Console.WriteLine("Length is {0}", length);
        }
    }
}
