using LeetCodeTest.Algo.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.BinaryTree
{
    public class ConstructBinarySearchTreefromPreorderTraversalTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ConstructBinarySearchTreefromPreorderTraversalTest1(int[] preorder, TreeNode result)
        {
            var p = new Solution1008();

            Assert.Equal(p.BstFromPreorder(preorder), result);
            Assert.Equal(p.BstFromPreorderMethod1(preorder), result);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
        new object[] {
             new int[] {8,5,1,7,10,12},
             new TreeNode(8, new TreeNode(5, new TreeNode(1, null, null), new TreeNode(7,null,null)), new TreeNode(10, null, new TreeNode(12)))
             },
        };
    }
}