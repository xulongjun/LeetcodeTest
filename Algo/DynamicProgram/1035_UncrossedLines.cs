using System;

namespace LeetCodeTest.Algo.DynamicProgram
{
    public class Solution1035
    {
        public int MaxUncrossedLines(int[] A, int[] B)
        {
            var dp = new int[A.Length + 1, B.Length + 1];

            for (int row = 1; row <= A.Length; row++)
            {
                for (int col = 1; col <= B.Length; col++)
                {
                    dp[row, col] = (A[row - 1] == B[col - 1]) ? dp[row - 1, col - 1] + 1 : Math.Max(dp[row - 1, col], dp[row, col - 1]);
                }
            }

            return dp[A.Length, B.Length];
        }
    }
}