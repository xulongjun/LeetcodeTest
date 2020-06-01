using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class ContiguousArrayTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ContiguousArrayTest1(int[] A, int result)
        {
            var p = new Solution525();
            Assert.Equal(p.FindMaxLength(A), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             new int[] {0,1,1,1,1,1,0},
             2
             },
        };
    }
}
