using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Algo.DynamicProgram
{
    class Solution518
    {
        public int Change(int amount, int[] coins)
        {
            int[] dp = new int[amount+1];
            dp[0] = 1;

            for (int i = 0; i< coins.Length; i++ )
            {
                for(int j = coins[i];j<=amount;j++)
                {
                    dp[j] += dp[j - coins[i]];
                }
            }

            return dp[amount];
        }
    }
}
