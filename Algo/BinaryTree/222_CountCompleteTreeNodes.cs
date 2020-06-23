using System;
using System.Collections.Generic;

namespace LeetCodeTest.Algo.BinaryTree
{
    public class Solution222
    {
        public int CountNodes(TreeNode root)
        {
            return root == null ? 0 : CountNodes(root.left) + CountNodes(root.right) + 1;
        }
    }
}

