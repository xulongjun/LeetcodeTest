using System;

namespace LeetCodeTest.Algo.DynamicProgram
{
    class Solution1277
    {
        public int CountSquares(int[][] matrix)
        {
            int length = matrix.Length;
            if (length == 0) return 0;

            int width = matrix[0].Length;
            int res = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (matrix[i][j] == 0) continue;

                    // border
                    if (i == 0 || j == 0)
                    {
                        res++;
                        continue;
                    }

                    // calculate min of different corner, and then plus himself
                    int min = Math.Min(matrix[i - 1][j - 1], Math.Min(matrix[i - 1][j], matrix[i][j - 1]));
                    matrix[i][j] += min;

                    res += matrix[i][j];
                }
            }

            return res;
        }
    }
}
