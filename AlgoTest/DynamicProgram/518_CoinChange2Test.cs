using LeetCodeTest.Algo.DynamicProgram;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.DynamicProgram
{
    public class CoinChange2Test
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CoinChange2Test1(int A, int[] B, int result)
        {
            var p = new Solution518();
            Assert.Equal(p.Change(A, B), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             5,
             new int[] {1,2,5 },
             4
             },
        new object[] {
             3,
             new int[] {2},
             0
             },
        };
    }
}
