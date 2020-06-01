using LeetCodeTest.Algo.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.BinaryTree
{
    public class InvertBinaryTreeTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void InvertBinaryTreeTest1(TreeNode root, TreeNode result)
        {
            var p = new Solution226();

            Assert.Equal(p.InvertTree(root), result);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
        new object[] {
             new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9))),
             new TreeNode(4, new TreeNode(7, new TreeNode(9), new TreeNode(6)), new TreeNode(2, new TreeNode(3), new TreeNode(1)))
        } };
    }
}
