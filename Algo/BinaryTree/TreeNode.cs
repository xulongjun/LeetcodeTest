using System;
using System.Diagnostics.CodeAnalysis;
//Definition for a binary tree node.

namespace LeetCodeTest.Algo.BinaryTree
{
    public class TreeNode : IEquatable<TreeNode>
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public bool Equals([AllowNull] TreeNode other)
        {
            return Equalilty(this, other);
        }

        private bool Equalilty(TreeNode x, TreeNode y)
        {
            if (x == null && y == null) return true;

            if ((x != null && y == null) || (x == null && y != null) || x.val != y.val) return false;

            return Equalilty(x.left, y.left) && Equalilty(x.right, y.right);
        }

        public int GetHashCode([DisallowNull] TreeNode obj)
        {
            return obj.GetHashCode();
        }
    }
}