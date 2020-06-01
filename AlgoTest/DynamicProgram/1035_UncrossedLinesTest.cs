using LeetCodeTest.Algo.DynamicProgram;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.DynamicProgram
{
    public class UncrossedLinesTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void UncrossedLinesTest1(int[] A, int[] B, int result)
        {
            var p = new Solution1035();
            Assert.Equal(p.MaxUncrossedLines(A, B), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             new int[] {2,5,1,2,5 },
             new int[] {10,5,2,1,5,2 },
             3
             },
        new object[] {
             new int[] {1,3,7,1,7,5 },
             new int[] {1,9,2,5,1 },
             2
             },
        };
    }
}
