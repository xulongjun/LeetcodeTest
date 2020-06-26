using LeetCodeTest.Algo.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.BinaryTree
{
    public class UniqueBinarySearchTreesTest
    {
        [Theory]
        [InlineData(3,5)]
        public void UniqueBinarySearchTreesTest1(int x, int result)
        {
            var p = new Solution96();

            Assert.Equal(p.NumTrees(x), result);
        }
    }
}

