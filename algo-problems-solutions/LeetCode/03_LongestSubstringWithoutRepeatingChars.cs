using System;

namespace algo_problems_solutions.LeetCode
{

    // Problem Description : https://leetcode.com/problems/longest-substring-without-repeating-characters/
    // Worst Case : O(N^2)
    class _03_LongestSubstringWithoutRepeatingChars
    {
        // Time Complexity is O(N^2)
        // Iterative approach was used to solve the problem.
        // It's composed of nested for loops where the outer loop
        // defines minimum index of the first character while the inner loop
        // specifies the maximum index of the last character
        public static int LengthOfLongestSubstring(string s)
        {
            // stores the longest maximum substring
            string longestSubstr = "";

            // breaks the input string in a character array
            char[] ch = s.ToCharArray();

            // loops until the end of the input string
            for (int i = 0; i < ch.Length; i++)
            {
                // breaks the loop when the length of the longest substring
                // is greater than the remaining characters
                if ((longestSubstr.Length) > (ch.Length - i))
                    break;

                string temp = "";
                // loops until the end of the input string
                // but begins using the first character of the outer loop
                for (int j = i; j < ch.Length; j++)
                {
                    // breaks inner loops when the character is already existing on the longest substring
                    if (temp.IndexOf(ch[j]) != -1)
                    {
                        break;
                    }
                    // stores the character on the substring
                    temp += ch[j];
                }

                // Checks if current length of substring is longer than the previous one
                if (temp.Length > longestSubstr.Length)
                {
                    longestSubstr = temp;
                }
            }

            // Returns longest substring's length
            return longestSubstr.Length;
        }

        public static void init()
        {
            //int length = LengthOfLongestSubstring("pwwkew");
            int length = LengthOfLongestSubstring("dvdf");
            Console.WriteLine("Length is {0}", length);
        }
    }
}
