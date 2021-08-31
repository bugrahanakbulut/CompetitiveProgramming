using System;

namespace LeetCode.Problems
{
    public class  KthLargestElementArray_Solution
    {
        public int FindKthLargest(int[] nums, int k) 
        {
            Array.Sort(nums);

            return nums[nums.Length - k];
        }
    }
}