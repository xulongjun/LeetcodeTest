using LeetCodeTest.Algo.DynamicProgram;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.DynamicProgram
{
    public class CountSquareSubmatricesWithAllOnesTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CountSquareSubmatricesWithAllOnesTest1(int[][] A, int result)
        {
            var p = new Solution1277();
            Assert.Equal(p.CountSquares(A), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             new int[][] { new int[] {0,1,1,1 },new int[] {1,1,1,1 },new int[] {0,1,1,1 } },
             15
             },
        };
    }
}
