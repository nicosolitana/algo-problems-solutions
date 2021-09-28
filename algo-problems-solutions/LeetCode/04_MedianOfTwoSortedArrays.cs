using System.Collections.Generic;

namespace algo_problems_solutions.LeetCode
{
    // Problem Description : https://leetcode.com/problems/median-of-two-sorted-arrays/submissions/
    // Best/Average/Worst Case : O(N + M)
    class _04_MedianOfTwoSortedArrays
    {

        // Time and Space Complexity of this function is O(N+M)
        // since it involves two arrays with sizes N and M
        // which can either have the same or not value.
        // Also, during merging, even though both arrays are already sorted
        // each value must be compared with each arrays current index 
        // to ensure that items are added on the new array are still sorted
        public int[] merge(int[] nums1, int[] nums2)
        {
            int i = 0;
            int j = 0;

            // stores the sorted merges values
            List<int> mergeLst = new List<int>();

            // loops infinitely
            while (true)
            {
                // breaks infinite loop if either of the two array's are
                // completely added on the merge list
                if ((i == nums1.Length) || (j == nums2.Length))
                    break;

                // compares value to check which one is
                // smaller to ensure that values are still sorted
                // after being added on the merge list
                if (nums1[i] > nums2[j])
                {
                    mergeLst.Add(nums2[j]);
                    j++;
                }
                else
                {
                    mergeLst.Add(nums1[i]);
                    i++;
                }
            }

            // at this point, only one of the following while loop will be performed
            // since the above while loop ensured that one array is already completely added
            // on the list.

            // adds remaining values on the first array to the merge list
            while (i != nums1.Length)
            {
                mergeLst.Add(nums1[i]);
                i++;
            }

            // adds remaining values on the second array to the merge list
            while (j != nums2.Length)
            {
                mergeLst.Add(nums2[j]);
                j++;
            }

            return mergeLst.ToArray();
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // merge and sorts the two arrays
            int[] mergeArr = merge(nums1, nums2);

            // When the length of the merge array is odd, 
            // then, return the value on middle index
            if (mergeArr.Length % 2 == 1)
                return mergeArr[mergeArr.Length / 2];
            else
            {
                // When the length of the merge array is even, 
                // Get the median of the values on indices middle and middle-1
                double firstNum = mergeArr[(mergeArr.Length / 2) - 1];
                double secondNum = mergeArr[mergeArr.Length / 2];
                return (firstNum + secondNum) / 2;
            }
        }
    }
}
