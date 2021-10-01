using System.Collections.Generic;

namespace algo_problems_solutions.Codility
{
    // Time Complexity is O(N)
    class _16_Brackets
    {
        public bool IsBalance(ref List<string> stack, string symbol)
        {
            if (stack.Count == 0)
                return false;

            if (stack[stack.Count - 1] == symbol)
                stack.RemoveAt(stack.Count - 1);
            else
                return false;
            return true;
        }
        public int solution(string S)
        {
            List<string> stack = new List<string>();
            bool flag = true;
            foreach (char c in S)
            {
                if (c == ')')
                {
                    flag = IsBalance(ref stack, "(");
                }
                else if (c == '}')
                {
                    flag = IsBalance(ref stack, "{");
                }
                else if (c == ']')
                {
                    flag = IsBalance(ref stack, "[");
                }
                else
                {
                    stack.Add("" + c);
                }

                if (flag == false)
                    return 0;
            }

            if (stack.Count != 0)
                return 0;

            return 1;
        }
    }
}
