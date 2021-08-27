using System;
using System.Linq;

namespace algo_problems_solutions.Implementation
{
    // HackerRank Problem
    // Same Letters, Same Count, Different Positions
    // Reference: https://www.youtube.com/watch?v=3MwRGPPB4tw&list=PLI1t_8YX-Apv-UiRlnZwqqrRT8D1RhriX&index=12
    class Anagram
    {
        private int CheckAnagram(string firstWord, string secondWord)
        {
            string allLetters = firstWord + secondWord;
            var uniqueLetters = allLetters.ToCharArray().Distinct();
            int fwCommonCount = 0;
            int swCommonCount = 0;

            foreach (var u in uniqueLetters)
            {
                if(firstWord.Contains(u) && (secondWord.Contains(u)))
                {
                    int fwCount = firstWord.Count(f => f == u);
                    int swCount = secondWord.Count(f => f == u);

                    if (fwCount != swCount)
                        return -1;
                    else
                    {
                        fwCommonCount += fwCount;
                        swCommonCount += swCount;
                    }
                }
            }

            int diff = Math.Abs((firstWord.Length - fwCommonCount) - (secondWord.Length - swCommonCount));
            return diff;
        }

    }
}
