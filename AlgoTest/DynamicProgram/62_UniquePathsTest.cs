using LeetCodeTest.Algo.DynamicProgram;
using Xunit;

namespace LeetCodeTest.AlgoTest.DynamicProgram
{
    public class UniquePathsTest
    {
        [Theory]
        [InlineData(3, 2, 3)]
        [InlineData(7, 3, 28)]
        public void UniquePathsTest1(int m, int n, int result)
        {
            var p = new Solution62();
            Assert.Equal(p.UniquePaths(m, n), result);
        }
    }
}
