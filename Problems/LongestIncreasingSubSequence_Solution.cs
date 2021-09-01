namespace LeetCode.Problems
{
    public class LongestIncreasingSubSequence_Solution
    {
        public int LengthOfLIS(int[] nums) 
        {
            int n = nums.Length;
            int[] lis = new int[n];

            for (int i = 0; i < n; i++) 
            {
                lis[i] = 1;
            }

            for (int i = 1; i < n; i++) 
            {
                for (int j = 0; j < i; j++) 
                {
                    if (nums[i] > nums[j] && lis[i] < lis[j] + 1) 
                    {
                        lis[i] = lis[j] + 1;
                    }
                }
            }

            int max = 1;

            for (int i = 0; i < n; i++)
            {
                if (max < lis[i])
                {
                    max = lis[i];
                }
            }
            
            return max;
        }
    }
}