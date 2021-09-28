using System;

namespace algo_problems_solutions.Codility
{
    class _01_BinaryGap
    {
        // Time Complexity is O(N)
        // where is the number of binary digits of an integer number
        public int GetMexBinaryGap(int N)
        {
            string binary = Convert.ToString(N, 2);
            bool start = false;
            int gapCount = 0, maxGap = 0;
            foreach (char b in binary)
            {
                if (b == '1')
                {
                    if (start == false)
                    {
                        start = true;
                    }
                    else
                    {
                        if (maxGap < gapCount)
                            maxGap = gapCount;
                        gapCount = 0;
                    }
                }

                if ((start == true) && (b != '1'))
                {
                    gapCount++;
                }
            }
            return maxGap;
        }
    }
}
