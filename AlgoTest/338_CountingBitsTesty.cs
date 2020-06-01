using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class CountingBitsTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CountingBitsTest1Test1(int A, int[] result)
        {
            var p = new Solution338();
            Assert.Equal(p.CountBits(A), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             8,
             new int[] {0,1,1,2,1,2,2,3,1 }
             },
        };
    }
}
