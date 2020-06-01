using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class IntervalListIntersectionsTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void IntervalListIntersectionsTest1(int[][] A, int[][] B, int[][] result)
        {
            var p = new Solution986();
            Assert.Equal(p.IntervalIntersection(A, B), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             new int[][] { new int[] { 0, 2 }, new int[] { 5, 10 }, new int[] { 13,23 },  new int[] { 24,25 }},
             new int[][] { new int[] { 1, 5 }, new int[] { 8, 12 }, new int[] { 15,24 },  new int[] { 25,26 }},
             new int[][] { new int[] { 1, 2 }, new int[] { 5, 5 }, new int[] { 8,10 },  new int[] { 15,23 }, new int[] { 24,24 },new int[] { 25,25 }}
             },
        };
    }
}
