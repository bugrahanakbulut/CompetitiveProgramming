namespace LeetCode.Problems
{
    public class MergeTwoBinaryTrees_Solution
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2) 
        {
            if (root1 == null && root2 == null) 
            {
                return null;
            }

            TreeNode mergeNode = new TreeNode();

            if (root1 != null) 
            {
                mergeNode.val += root1.val;
            }

            if (root2 != null) 
            {
                mergeNode.val += root2.val;
            }
            
            
            
            mergeNode.left = MergeTrees((root1 != null) ? root1.left : null, (root2 != null) ? root2.left : null);
            mergeNode.right = MergeTrees((root1 != null) ? root1.right : null, (root2 != null) ? root2.right : null);
            

            return mergeNode;
        }
    }
}