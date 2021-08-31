using System.Collections.Generic;
using static LeetCode.Problems.TreeNode;

namespace LeetCode.Problems
{
    public class KthSmallestElementBST_Solution
    {
        public int KthSmallest(TreeNode root, int k) 
        {
            List<int> inorder = new List<int>();

            InorderList(root, inorder);

            return inorder[k - 1];
        }

        private void InorderList(TreeNode root, List<int> list) 
        {
            if (root == null) 
            {
                return;
            }

            InorderList(root.left, list);

            list.Add(root.val);

            InorderList(root.right, list);
        }
    }
}