using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class TargetSum_Solution
    {
        private Dictionary<int, int>[] _solution;
        
        public int FindTargetSumWays(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            _solution = new Dictionary<int, int>[nums.Length + 1];

            for (int i = 0; i < nums.Length + 1; i++)
            {
                _solution[i] = new Dictionary<int, int>();
            }

            return FindTargetSumWays(nums, 0, target);
        }

        private int FindTargetSumWays(int[] nums, int index, int target)
        {
            if (index == nums.Length)
            {
                if (!_solution[index].ContainsKey(target))
                {
                    int res = (target == 0) ? 1 : 0;

                    _solution[index].Add(target, res);
                }

                return _solution[index][target];
            }

            if (_solution[index].ContainsKey(target))
            {
                return _solution[index][target];
            }

            _solution[index].Add(
                target, 
                FindTargetSumWays(nums, index + 1, target - nums[index]) + 
                FindTargetSumWays(nums, index + 1, target + nums[index]));

            return _solution[index][target];
        }
    }
}