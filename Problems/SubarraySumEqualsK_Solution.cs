using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class SubarraySumEqualsK_Solution
    {
        public int SubarraySum(int[] nums, int k) 
        {
            int sum = 0;
            int count = 0;
            int n = nums.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 1);
            for (int i = 0; i < n; i++) 
            {
                sum += nums[i];

                if (dict.ContainsKey(sum - k)) 
                {
                    count += dict[sum - k];
                }

                if (!dict.ContainsKey(sum)) 
                {
                    dict.Add(sum, 1);
                }
                else 
                {
                    dict[sum]++;
                }
            }

            return count;
        }
    }
}