using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class SearchInsertPosition
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void SearchInsertPositionTest1(int[] B, int target, int result)
        {
            var p = new Solution35();
            Assert.Equal(p.SearchInsert(B, target), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {       
             new int[] {1,3,5,6},
             5,2
             },
        new object[] {
             new int[] {1,3,5,6},
             2,1
             },
         new object[] {
             new int[] {1,3,5,6},
             7,4
             },
        };

    }
}
