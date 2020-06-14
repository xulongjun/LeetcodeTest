using System;

namespace LeetCodeTest.Algo.DynamicProgram
{
    public class Solution787
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
        {
            int[,] dp = new int[K + 2, n];

            for(int i = 0; i< K+2; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    dp[i,j] = int.MaxValue;
                }

                dp[i,src] = 0;
            }

            for (int i=1; i <= K+1; i++)
            {
                for (int j=0;j< flights.Length;j++)
                {
                    int[] flight = flights[j];

                    if(dp[i - 1, flight[0]] != int.MaxValue)
                    {
                        dp[i, flight[1]] = Math.Min(dp[i, flight[1]], dp[i - 1, flight[0]] + flight[2]);
                    }
                }
            }

            return dp[K+1,dst] >= int.MaxValue ? -1 : dp[K + 1,dst];
        }
    }
}