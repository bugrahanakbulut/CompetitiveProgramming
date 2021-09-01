using System;

namespace LeetCode.Problems
{
    public class FindDuplicateNumber_Solution
    {
        public int FindDuplicate(int[] nums) 
        {
            int duplicateElem = -1;

            for (int i = 0; i < nums.Length; i++) 
            {
                int cur = Math.Abs(nums[i]);

                if (nums[cur] < 0) 
                {
                    duplicateElem = nums[i];
                    break;
                }

                nums[cur] *= -1;
            }

            for (int i = 0; i < nums.Length; i++) 
            {
                nums[i] = Math.Abs(nums[i]);
            }

            return Math.Abs(duplicateElem);
        }
    }
}