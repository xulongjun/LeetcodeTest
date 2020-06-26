using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Algo.BinaryTree
{
    class Solution129
    {
        public int SumNumbers(TreeNode root)
        {
			int sum = nodeSum(root, 0);
			return sum;
		}

		private int nodeSum(TreeNode node, int sum)
		{
			if (node == null)
			{
				return 0;
			}

			int next = sum * 10 + node.val;

			if (node.left == null && node.right == null)
			{
				return next;
			}

			int left = nodeSum(node.left, next);
			int right = nodeSum(node.right, next);
			return left + right;
		}
	}
}
