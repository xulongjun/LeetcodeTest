using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class PermutationSequenceTest
    {
        [Theory]
        [InlineData(3, 3, "213")]
        [InlineData(4, 9, "2314")]
        public void PermutationSequenceTest1(int A, int B, string result)
        {
            var p = new Solution60();
            Assert.Equal(p.GetPermutation(A, B), result);
        }
    }
}
