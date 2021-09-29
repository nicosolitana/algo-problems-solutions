using System;
using System.Collections.Generic;
using System.Text;

namespace algo_problems_solutions.Codility
{
    class _04_FrogJump
    {
        public int solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return Convert.ToInt32(Math.Ceiling(((double)Y - (double)X) / (double)D));
        }
    }
}
