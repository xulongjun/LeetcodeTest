using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class PrisonCellsAfterNDaysTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CountingBitsTest1Test1(int[] cells, int N, int[] result)
        {
            var p = new Solution957();
            Assert.Equal(p.PrisonAfterNDays(cells, N), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
         new object[] {
             new int[] {0,1,0,1,1,0,0,1 },
             7,
             new int[] { 0, 0, 1, 1, 0, 0, 0, 0 }
             },
        new object[] {
             new int[] {1,0,0,1,0,0,1,0},
             1000000000,
             new int[] { 0, 0, 1, 1, 1, 1, 1, 0 }
             },
        };
    }
}
