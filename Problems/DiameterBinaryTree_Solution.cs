using System;

namespace LeetCode.Problems
{
    public class DiameterBinaryTree_Solution
    {

        private int _diameter = 0;

        public int DiameterOfBinaryTree(TreeNode root) 
        {
            _diameter = 0;

            Height(root);

            return _diameter;
        }

        private int Height(TreeNode root) 
        {
            if (root == null) 
            {
                return 0;
            }

            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);

            _diameter = Math.Max(_diameter, leftHeight + rightHeight + 2);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

    }
}