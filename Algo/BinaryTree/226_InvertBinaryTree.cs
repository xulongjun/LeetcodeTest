using System;
using System.Collections.Generic;

namespace LeetCodeTest.Algo.BinaryTree
{
    public class Solution226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            if (root.left != null || root.right != null)
            {
                TreeNode temp = root.left;

                root.left = root.right;
                root.right = temp;

                InvertTree(root.left);
                InvertTree(root.right);
            }

            return root;
        }
    }
}

