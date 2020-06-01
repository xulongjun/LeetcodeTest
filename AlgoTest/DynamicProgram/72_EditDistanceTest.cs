using LeetCodeTest.Algo.DynamicProgram;
using Xunit;

namespace LeetCodeTest.AlgoTest.DynamicProgram
{
    public class EditDistanceTest
    {
        [Theory]
        [InlineData("intention", "execution", 5)]
        [InlineData("horse", "ros", 3)]
        public void EditDistanceTest1(string A, string B, int result)
        {
            var p = new Solution72();
            Assert.Equal(p.MinDistance(A, B), result);
            Assert.Equal(p.MinDistance2(A, B), result);
        }
    }
}
