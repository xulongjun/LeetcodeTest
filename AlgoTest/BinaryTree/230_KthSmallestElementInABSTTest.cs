using LeetCodeTest.Algo.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.BinaryTree
{
    public class KthSmallestElementInABSTTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void KthSmallestElementInABSTTest1(TreeNode root, int k, int result)
        {
            var p = new Solution230();

            Assert.Equal(p.KthSmallest(root, k), result);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
        new object[] {
             new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4, null, null)), 1, 1 },
        new object[] {
             new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1)), new TreeNode(4)), new TreeNode(6)), 3, 3 },
        };
    }
}
