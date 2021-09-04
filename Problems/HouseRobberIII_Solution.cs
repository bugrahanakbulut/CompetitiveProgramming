using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class HouseRobberIII_Solution
    {
        Dictionary<TreeNode, int> memo = new Dictionary<TreeNode, int>();

        public int Rob(TreeNode root) 
        {
            if (root == null) 
            {
                return 0;
            }

            if (memo.ContainsKey(root)) 
            {
                return memo[root];
            }

            int sum = root.val;

            if (root.left != null) 
            {
                sum += Rob(root.left.left);
                sum += Rob(root.left.right);
            }

            if (root.right != null) 
            {
                sum += Rob(root.right.left);
                sum += Rob(root.right.right);
            }

            int childSum = Rob(root.left) +  Rob(root.right);


            int res = Math.Max(sum, childSum);
            
            memo.Add(root, res);

            return res;
        }
    }
}