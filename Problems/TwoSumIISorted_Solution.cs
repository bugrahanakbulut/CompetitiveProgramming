namespace LeetCode.Problems
{
    public class TwoSumIISorted_Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }

                if (sum > target)
                {
                    right--;
                }
                if (sum < target)
                {
                    left++;
                }
            }

            return null;
        }
    }
}