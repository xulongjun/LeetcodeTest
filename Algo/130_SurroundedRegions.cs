using System.Linq;
using System.Collections.Generic;
using System;

namespace LeetCodeTest.Algo
{
    public class Solution130
    {
        public void Solve(char[][] board)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0) return;
            int l = board.Length;
            int c = board[0].Length;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == 0 || j == 0 || i == l - 1 || j == c - 1)
                    {
                        if (board[i][j] == 'O')
                            DfsO(board, i, j);
                    }
                }
            }

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (board[i][j] == 'O') board[i][j] = 'X';
                    if (board[i][j] == 'G') board[i][j] = 'O';
                }
            }
        }

        private void DfsO(char[][] board, int i, int j)
        {
            board[i][j] = 'G';

            if (i - 1 >= 0 && board[i - 1][j] == 'O')
            {
                DfsO(board, i - 1, j);
            }

            if (i + 1 < board.Length && board[i + 1][j] == 'O')
            {
                DfsO(board, i + 1, j);
            }

            if (j - 1 >= 0 && board[i][j - 1] == 'O')
            {
                DfsO(board, i, j - 1);
            }

            if (j + 1 < board[0].Length && board[i][j + 1] == 'O')
            {
                DfsO(board, i, j + 1);
            }
        }
    }
}