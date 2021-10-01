using System.Linq;

namespace algo_problems_solutions.Codility
{
    class _14_Distinct
    {
        // Time Complexity is O(N) or O(N log N)
        public int solution(int[] A)
        {
            var B = A.Distinct().ToArray();
            return B.Length;
        }
    }
}
