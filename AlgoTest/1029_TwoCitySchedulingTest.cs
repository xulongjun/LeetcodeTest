using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class TwoCitySchedulingTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TwoCitySchedulingTest1(int[][] B, int result)
        {
            var p = new Solution1029();
            Assert.Equal(p.TwoCitySchedCost(B), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             new int[][] { new int[] { 10,20 }, new int[] {30,200 }, new int[] { 400,50} , new int[] { 30,20 } },
                 110
             },
        };
    }
}
