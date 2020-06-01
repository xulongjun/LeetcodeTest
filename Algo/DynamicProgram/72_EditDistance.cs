using System;

namespace LeetCodeTest.Algo.DynamicProgram
{
    public class Solution72
    {
        public int MinDistance(string word1, string word2)
        {
            int m = word1.Length;
            int n = word2.Length;
            int[,] dp = new int[m + 1, n + 1];

            // Fill d[][] in bottom up manner 
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    // If first string is empty, only option is to 
                    // insert all characters of second string 
                    if (i == 0)

                        // Min. operations = j 
                        dp[i, j] = j;

                    // If second string is empty, only option is to 
                    // remove all characters of second string 
                    else if (j == 0)

                        // Min. operations = i 
                        dp[i, j] = i;

                    // If last characters are same, ignore last char 
                    // and recur for remaining string 
                    else if (word1[i - 1] == word2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1];

                    // If the last character is different, consider all 
                    // possibilities and find the minimum 
                    else
                        dp[i, j] = 1 + Math.Min(Math.Min(dp[i, j - 1], // Insert 
                                           dp[i - 1, j]), // Remove 
                                           dp[i - 1, j - 1]); // Replace 
                }
            }

            return dp[m, n];
        }

        public int MinDistance2(string word1, string word2)
        {
            int m = word1.Length;
            int n = word2.Length;
            int[,] dp = new int[2, n + 1];

            for (int i = 0; i <= n; i++)
                dp[0, i] = i;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (j == 0)
                        dp[i % 2, j] = i;

                    else if (word1[i - 1] == word2[j - 1])
                        dp[i % 2, j] = dp[(i - 1) % 2, j - 1];

                    else
                        dp[i % 2, j] = 1 + Math.Min(Math.Min(dp[i % 2, j - 1], // Insert 
                                           dp[(i - 1) % 2, j]), // Remove 
                                           dp[(i - 1) % 2, j - 1]); // Replace 
                }
            }

            return dp[m % 2, n];
        }
    }
}