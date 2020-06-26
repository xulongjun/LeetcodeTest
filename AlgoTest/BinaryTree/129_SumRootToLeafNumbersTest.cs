using LeetCodeTest.Algo.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.BinaryTree
{
    public class SumRootToLeafNumbersTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void SumRootToLeafNumbersTest1(TreeNode root, int result)
        {
            var p = new Solution129();

            Assert.Equal(p.SumNumbers(root), result);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
        new object[] {
             new TreeNode(1, new TreeNode(2), new TreeNode(3)),
             25
        } };
    }
}
