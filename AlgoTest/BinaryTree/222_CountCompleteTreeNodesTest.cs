using LeetCodeTest.Algo.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.BinaryTree
{
    public class CountCompleteTreeNodesTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CountCompleteTreeNodesTest1(TreeNode root, int result)
        {
            var p = new Solution222();

            Assert.Equal(p.CountNodes(root), result);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
        new object[] {
             new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6))),
            6
        } };
    }
}
