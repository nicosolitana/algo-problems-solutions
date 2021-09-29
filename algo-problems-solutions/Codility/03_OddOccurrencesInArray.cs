using System.Linq;

namespace algo_problems_solutions.Codility
{
    // Best Case is O(N)
    // Worst Case is O(N^2)
    class _03_OddOccurrencesInArray
    {
        // Time Complexity of this solution is O(N)
        public int GetPair2(int[] A)
        {
            // Aggregate loops on the array
            // and saves the first and second value then perform an operation
            return A.Aggregate((x, y) => x ^ y);
        }

        private int GetPairValue(int[] A, bool[] HasPair, int currentIndex)
        {
            int index = -1;
            for (int i= currentIndex+1; i< A.Length; i++)
            {
                if((A[currentIndex] == A[i]) && (HasPair[i] == false))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // Time Complexity of this solution is O(N^2)
        // However, in case there are hard limit on time.
        // This would not be an appropriate solution
        // as this would exceed the hard limit on large inputs
        public int GetPair1(int[] A)
        {
            // Creates a boolean array which checks if the pairing 
            // has already performed or not yet
            // False: has not yet paired with another value
            // True: has already paired with another value
            bool[] HasPair = new bool[A.Length];
            for (int i = 0; i < A.Length; i++)
                HasPair[i] = false;

            int NoPair = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (HasPair[i] == false)
                {
                    int index = GetPairValue(A, HasPair, i);
                    if (index == -1)
                    {
                        NoPair = A[i];
                        break;
                    }
                    HasPair[i] = true;
                    HasPair[index] = true;
                }
            }
            return NoPair;
        }
    }
}
