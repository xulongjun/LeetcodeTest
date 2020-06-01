using LeetCodeTest.Algo.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.BinaryTree
{
    public class CousinsInBinaryTreeTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CousinsInBinaryTreeTest1(TreeNode root, int x, int y, bool result)
        {
            var p = new Solution993();

            Assert.Equal(p.IsCousinsBFS(root, x, y), result);
            Assert.Equal(p.IsCousinsDFS(root, x, y), result);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
        new object[] {
             new TreeNode(1, new TreeNode(2, new TreeNode(4, null, null), null), new TreeNode(3, null, null)), 4, 3, false },
        new object[] {
             new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(5))), 5, 4, true },
        };
    }
}

