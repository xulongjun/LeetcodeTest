using LeetCodeTest.Algo.DynamicProgram;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.DynamicProgram
{
    public class LargestDivisibleSubsetTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void LargestDivisibleSubsetTest1(int[] A, IList<int> result)
        {
            var p = new Solution368();
            Assert.Equal(p.LargestDivisibleSubset(A), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        //new object[] {
        //     new int[] {1, 2, 3},
        //     new List<int>() {1, 2},
        //     },
        new object[] {
             new int[] {1, 2, 4, 6, 8},
             new List<int>() {1, 2, 4 ,8},
             },
        //new object[] {
        //     new int[] {3, 4, 7, 8, 12},
        //     new List<int>() {4, 8},
        //     },
        };
    }
}
