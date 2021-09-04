using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class PartitionEqualSubsetSum_Solution
    {
        public bool CanPartition(int[] nums) 
        {
            int sum = 0;

            foreach(int i in nums) 
            {
                sum += i;
            }

            if (sum % 2 == 1) 
            {
                return false;
            }

            int[,] dp = new int[nums.Length, sum / 2 + 1];
            return EqualPartition(dp, nums, sum / 2, 0) == 1;
        }

        private int EqualPartition(int[,] dp, int[] nums, int sum, int curIndex) 
        {
            if (sum == 0) 
            {
                return 1;
            }

            if (nums.Length == 0 || curIndex >= nums.Length) 
            {
                return -1;
            }

            if (dp[curIndex, sum] == 0) 
            {
                if (nums[curIndex] <= sum) 
                {
                    int res = EqualPartition(dp, nums, sum - nums[curIndex], curIndex + 1);

                    if (res > 0) 
                    {
                        dp[curIndex, sum]= 1;

                        return res;
                    }
                }

                dp[curIndex, sum] = EqualPartition(dp, nums, sum, curIndex + 1);
            }

            return dp[curIndex, sum];
        }
    }
}