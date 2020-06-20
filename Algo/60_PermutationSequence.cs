using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Algo
{
    public class Solution60
    {
        public string GetPermutation(int n, int k)
        {
            List<int> numbers = new List<int>();
            int[] factorial = new int[n + 1];
            StringBuilder sb = new StringBuilder();

            factorial[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
                factorial[i] = factorial[i - 1] * i;
            }

            k--;

            for (int i = n; i > 0; i--)
            {
                int index = k / factorial[i - 1];
                k = k % factorial[i - 1];
                sb.Append(numbers[index]);
                numbers.RemoveAt(index);
            }

            return sb.ToString();
        }
    }
}