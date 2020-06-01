using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class PossibleBipartitionTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void PossibleBipartitionTest1(int N, int[][] B, bool result)
        {
            var p = new Solution886();
            Assert.Equal(p.PossibleBipartition(N, B), result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
         new object[] {
             10,
             new int[][] { new int[] {4, 7 },new int[] {4, 8 }, new int[] {2, 8 },new int[] {8, 9 },new int[] {1, 6 }, new int[] {5, 8 },new int[] {1, 2 },new int[] {6, 7 }, new int[] {3, 10 }, new int[] {8, 10 },new int[] {1, 5 }, new int[] {7, 10 },new int[] {1, 10 },new int[] {3, 5 }, new int[] {3, 6 }, new int[] {1, 4 },new int[] {3, 9 }, new int[] {2, 3 },new int[] {1, 9 }, new int[] {7, 9 }, new int[] {3, 4 }, new int[] {5, 7 }, new int[] {3, 4 }},
             true
             },

        new object[] {
             5,
             new int[][] { new int[] {1, 2 },new int[] {1, 3 }, new int[] {2, 4 },new int[] {1, 5 } },
             true
             },
        new object[] {
             3,
             new int[][] { new int[] {1, 2 },new int[] {1, 3 }, new int[] {2, 3 } },
             false
             },
        new object[] {
             5,
             new int[][] { new int[] {1, 2 },new int[] {3, 4 }, new int[] {4, 5 },  new int[] {3, 5 } },
             false
             },
        };
    }
}
