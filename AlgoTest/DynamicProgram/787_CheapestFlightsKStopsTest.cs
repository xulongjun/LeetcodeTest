using LeetCodeTest.Algo.DynamicProgram;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest.DynamicProgram
{
    public class CheapestFlightsKStopsTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CheapestFlightsKStopsTest1(int n, int[][] flights, int src, int dst, int K, int result)
        {
            var p = new Solution787();
            Assert.Equal(p.FindCheapestPrice(n, flights, src, dst, K), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             3,
             new int[][] { new int[] {0,1,100 },new int[] {1,2,100 },new int[] {0,2,500 } },
             0,
             2,
             1,
             200
             },
        new object[] {
             3,
             new int[][] { new int[] {0,1,100 },new int[] {1,2,100 },new int[] {0,2,500 } },
             0,
             2,
             0,
             500
             },
        };
    }
}
