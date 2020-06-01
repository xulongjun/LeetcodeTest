using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class CourseScheduleTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CourseScheduleTest1(int N, int[][] B, bool result)
        {
            var p = new Solution207();
            Assert.Equal(p.CanFinish(N, B), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             8,
             new int[][] { new int[] { 1,0 }, new int[] {7,0 }, new int[] { 1,7} , new int[] { 3,1 },
             new int[] { 5,1},new int[] {6,4 },new int[] { 2,6}},
             true
             },
        };
    }
}
