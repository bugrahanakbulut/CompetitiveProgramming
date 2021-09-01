using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class LowestCommonAncestorBinaryTree_Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
        {
            if (root == null) 
            {
                return null;
            }

            
            Dictionary<TreeNode, TreeNode> parentDict = GetParentsDict(root);

            TreeNode tmp = p;

            HashSet<TreeNode> path = new HashSet<TreeNode>();

            while (tmp != null) 
            {
                path.Add(tmp);

                tmp = parentDict[tmp];
            }

            tmp = q;

            while (tmp != null) 
            {
                if (path.Contains(tmp)) 
                {
                    return tmp;
                }

                tmp = parentDict[tmp];
            }

            return null;
        }

        private Dictionary<TreeNode, TreeNode> GetParentsDict(TreeNode root) 
        {
            Dictionary<TreeNode, TreeNode> parentDict = new Dictionary<TreeNode, TreeNode>();

            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();

            nodeQueue.Enqueue(root);
            parentDict.Add(root, null);

            while(nodeQueue.Count != 0) 
            {
                TreeNode curNode = nodeQueue.Dequeue();

                if (curNode.left != null) 
                {
                    nodeQueue.Enqueue(curNode.left);

                    parentDict.Add(curNode.left, curNode);
                }

                if (curNode.right != null) 
                {
                    nodeQueue.Enqueue(curNode.right);

                    parentDict.Add(curNode.right, curNode);
                }
            }

            return parentDict;
        }
    }
}