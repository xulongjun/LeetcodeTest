using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Algo.BinaryTree
{
    class Solution96
    {
		public int NumTrees(int n)
		{
			int[] d = new int[n + 1];
			d[0] = 1;

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					int left = d[j - 1];
					int right = d[i - j];
					d[i] += left * right;
				}
			}
			return d[n];
		}
	}
}
