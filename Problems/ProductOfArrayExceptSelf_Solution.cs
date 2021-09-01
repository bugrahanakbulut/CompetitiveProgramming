namespace LeetCode.Problems
{
    public class ProductOfArrayExceptSelf_Solution
    {
        public int[] ProductExceptSelf(int[] nums) 
        {
            int n = nums.Length;

            int[] result = new int[n];

            result[0] = 1;

            for (int i = 1; i < n; i++) 
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int mul = nums[n - 1];

            for (int i = n - 2; i >= 0; i--) 
            {
                result[i] = result[i] * mul;

                mul = mul * nums[i];
            }

            return result;
        }
    }
}