using LeetCodeTest.Algo;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class SurroundedRegionsTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void SurroundedRegionsTest1(char[][] A, char[][] B)
        {
            var p = new Solution130();
            p.Solve(A);

            for(int i = 0; i<A.Length; i++ )
            {
                Assert.True(Enumerable.SequenceEqual(A[i], B[i]));
            }         
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] {
             new char[][] { new char[] { 'X', 'X', 'X', 'X' }, new char[] { 'X', 'O', 'O', 'X' }, new char[] { 'X', 'X', 'O', 'X' } , new char[] { 'X', 'O', 'X', 'X' } },
             new char[][] { new char[] { 'X', 'X', 'X', 'X' }, new char[] { 'X', 'X', 'X', 'X' }, new char[] { 'X', 'X', 'X', 'X' } , new char[] { 'X', 'O', 'X', 'X' } },
             },
        };
    }
}
