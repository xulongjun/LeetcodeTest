using LeetCodeTest.Algo.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.BinaryTree
{
    public class AllTraversalOrderTest
    {
        public AllTraversalOrder Program { get; set; } = new AllTraversalOrder();

        [Theory]
        [MemberData(nameof(DataPreorder))]
        public void PreorderTraversalTest(TreeNode root, List<int> result)
        {
            Assert.Equal(Program.PreorderTraversalDfs(root), result);
            Assert.Equal(Program.PreorderTraversalBfs(root), result);
        }

        public static IEnumerable<object[]> DataPreorder => new List<object[]>
        {
        new object[] {
             new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null)),
             new List<int>(){1,2,3}
             },
        };

        [Theory]
        [MemberData(nameof(DataInorder))]
        public void InorderTraversalTest(TreeNode root, List<int> result)
        {
            Assert.Equal(Program.InorderTraversalDfs(root), result);
            Assert.Equal(Program.InorderTraversalBfs(root), result);
        }

        public static IEnumerable<object[]> DataInorder => new List<object[]>
        {
        new object[] {
             new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null)),
             new List<int>(){1,3,2}
             },
        };

        [Theory]
        [MemberData(nameof(DataPostorder))]
        public void PostorderTraversalTest(TreeNode root, List<int> result)
        {
            Assert.Equal(Program.PostorderTraversalDfs(root), result);
            Assert.Equal(Program.PostorderTraversalBfs(root), result);
        }

        public static IEnumerable<object[]> DataPostorder => new List<object[]>
        {
        new object[] {
             new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null)),
             new List<int>(){3,2,1}
             },
        };


        [Theory]
        [MemberData(nameof(DataLevelOrder))]
        public void LevelOrderTraversalTest(TreeNode root, List<List<int>> result)
        {
            Assert.Equal(Program.LevelOrderBfs(root), result);
            Assert.Equal(Program.LevelOrderDfs(root), result);
        }

        public static IEnumerable<object[]> DataLevelOrder => new List<object[]>
        {
        new object[] {
             new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))),
             new List<List<int>>(){ new List<int>() {3 }, new List<int>() {9,20 }, new List<int>() { 15, 7} }
             },
        };

    }
}
