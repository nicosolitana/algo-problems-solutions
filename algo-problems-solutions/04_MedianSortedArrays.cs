using System;

namespace algo_problems_solutions
{
    // Problem Description : https://leetcode.com/problems/median-of-two-sorted-arrays/
    // Worst Case : O(M+N)
    // Algorithm used is Merge Sort to merge and sort input arrays.
    // Simple division and subtraction was used to get median values indices
    static class _04_MedianSortedArrays
    {
        // Time Complexity is O(M+N)
        // This function merges and sorts the two input arrays of integers.
        // It assumes that both arrays are already sorted.
        public static void Merge(int[] arr, int[] nums1, int[] nums2)
        {
            // iterator for nums1, nums2 and arr respectively
            int i = 0, j = 0, k=0;

            // loops until either of the inputs arrays are completely traversed
            while((i < nums1.Length) && (j < nums2.Length))
            {
                // adds minimum value on the arr
                // and increments iterator used by the input array and arr
                if (nums1[i] > nums2[j])
                {
                    arr[k] = nums2[j];
                    j++;
                }
                else
                {
                    arr[k] = nums1[i];
                    i++;
                }
                k++;
            }

            // in case there are still values from first input array
            // that are not yet stored on arr, add all remaining values on arr
            while (i < nums1.Length)
            {
                arr[k] = nums1[i];
                i++;
                k++;
            }

            // in case there are still values from second input array
            // that are not yet stored on arr, add all remaining values on arr
            while (j < nums2.Length)
            {
                arr[k] = nums2[j];
                j++;
                k++;
            }
        }

        // Time Complexity is O(1)
        // But taking into consideration the merge sort that it uses,
        // it will take an O(M+N) time complexity.
        // This takes two input arrays and outputs the median.
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Retrieval of median value indices
            int len = nums1.Length + nums2.Length;
            int midCeil=0, midFloor=0;
            if (len%2 == 0)
            {
                midCeil = (len) / 2;        
                midFloor = midCeil - 1;
            } else
            {
                midFloor = len / 2;
            }

            // Merge and Sorts two input arrays and stores on temp array
            int[] temp = new int[len];
            Merge(temp, nums1, nums2);

            // Returns median value
            if (midCeil == 0)
                return temp[midFloor];
            else
                return (double)(temp[midFloor] + temp[midCeil]) / 2;
        }

        public static void init()
        {
            //int length = LengthOfLongestSubstring("pwwkew");
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            //int[] nums1 = { 1, 3 };
            //int[] nums2 = { 2 };
            double mid = FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine("Length is {0}", mid);
        }
    }
}

