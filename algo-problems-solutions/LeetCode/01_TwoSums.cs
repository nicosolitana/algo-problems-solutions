using System.Collections.Generic;
using System.Linq;

namespace algo_problems_solutions.LeetCode
{
    // Problem Description : https://leetcode.com/problems/two-sum/
    // Best/Average Case : O(N)
    // Worst Case : O(N^2)
    // Iterative approach is used on both algorithms.
    class _01_TwoSums
    {

        // Time Complexity is O(N)
        // Iterative approach is used to determine if there are two distinct values
        // in the list that would sum based on target's value
        public int[] TwoSum_ON(int[] nums, int target)
        {
            List<int> numLst = nums.ToList();
            int[] res = new int[2];

            // Loop until all items of the list or atleast, when two values that
            // sum up to the target is dectected
            for (int i = 0; i < nums.Length; i++)
            {
                // Subtract current value to target
                int sub = target - nums[i];

                // Check if the difference of current value and target 
                // exists as an item in the list
                int index = numLst.IndexOf(sub);

                // In case, the two values are already reached even if the entire list is not
                // yet traversed, this code save the two values and breaks the loop
                // which not only optimizes the code but as well as 
                // prevent further unnecessary looping operation
                if (index != -1)
                {
                    res[0] = i;
                    res[1] = index;
                    break;
                }
            }
            // The speed of this algorithm increases on a linear scale as the input n increases.
            // This is because the for loop will execute for n number of times where
            // n pertains to the size of the input array.
            // Thus, forming the O(N) time complexity.

            return res;
        }


        // Time Complexity is O(N^2) 
        // Another variation of the iterative approach.
        // Here, the goal is to compare current value to other values in the list
        // one by one.
        public int[] TwoSum_ON2(int[] nums, int target)
        {
            int[] res = new int[2];

            // Loops until the last value in the list
            // This is used as the basis of the first value that will be
            // compared to another value to check if they both sum to target
            for(int i=0; i<nums.Length; i++){

                // Loops until the last value in the list
                // This is used as the basis of the second value that will be compared on 
                // the first value extracted from the outer loop
                for (int j=0; j<nums.Length; j++){

                    // Perform only comparison if indexes i and j are not the same
                    // this is to prevent the same value to be used at the same time
                    if(j!=i) {

                        // Check if first and second value sums to target,
                        // the return these two values
                        if((nums[i] + nums[j]) == target){
                            res[0] = i;
                            res[1] = j;
                            return res;
                        }
                    }
                }
                // What makes this inefficient is that, this algorithm will increase speed 
                // quadratically as the number of inputs increases.
                // The inner loop will execute n times which will also be executed for n times 
                // based on the outer loop. This makes the program executin=on N*N.
                // Thus, resuting to an O(N^2) time complexity which is bad.
            }
            return res;
        }
    }
}
