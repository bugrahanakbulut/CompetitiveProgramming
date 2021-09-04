using System;

namespace LeetCode.Problems
{
    public class PathSumIII_Solution
    {
        public int PathSum(TreeNode root, int sum)
        {
            if (root == null) 
            {
                return 0;
            }

            return PathSum(root.left, sum) + PathSumHelper(root, sum) + PathSum(root.right, sum);
        }

        public int PathSumHelper(TreeNode root, int targetSum) 
        {
            if (root == null) 
            {
                return 0;
            }

            int result = 0;

            if (root.val == targetSum) 
            {
                result++;
            }

            result += PathSumHelper(root.left, targetSum - root.val);
            result += PathSumHelper(root.right, targetSum - root.val);

            return result;
        }

        
    }
}