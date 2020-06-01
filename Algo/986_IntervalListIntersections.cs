using System;
using System.Collections.Generic;

namespace LeetCodeTest.Algo
{
    public class Solution986
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            var lenA = A.Length;
            var lenB = B.Length;

            var result = new List<int[]>();

            int i = 0; int j = 0;

            while (i < lenA && j < lenB)
            {
                var beginA = A[i][0];
                var endA = A[i][1];
                var beginB = B[j][0];
                var endB = B[j][1];

                if (beginB > endA)
                {
                    i++;
                    continue;
                }
                else if (beginA > endB)
                {
                    j++;
                    continue;
                }
                else
                {
                    var begin = Math.Max(beginA, beginB);
                    var end = Math.Min(endA, endB);
                    result.Add(new int[] { begin, end });

                    if (endB > endA) i++;
                    else j++;
                }
            }

            return result.ToArray();
        }
    }
}