using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class QueueReconstructionByHeightTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void QueueReconstructionByHeightTest1(int[][] B, int[][] result)
        {
            var p = new Solution406();
            Assert.Equal(p.ReconstructQueue(B), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             new int[][] { new int[] { 7,0 }, new int[] {4,4 }, new int[] { 7,1} , new int[] { 5,0 },new int[] {6,1},new int[] { 5,2 } },
             new int[][] { new int[] { 5,0 }, new int[] {7,0 }, new int[] { 5,2} , new int[] { 6,1 },new int[] {4,4},new int[] { 7,1 } }
             },
        };
    }
}
