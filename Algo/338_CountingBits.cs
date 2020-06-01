using System;

namespace LeetCodeTest.Algo
{
    public class Solution338
    {
        public int[] CountBits(int num)
        {
            int[] result = new int[num + 1];
            result[0] = 0;

            int n = -1;

            for (int i = 1; i <= num; i++)
            {
                int split = (int)Math.Pow(2, n);

                int x = split != 0 ? i % split : 0;

                if (x == 0)
                {
                    n++;
                    result[i] = 1;
                }
                else
                {
                    result[i] = result[x] + 1;
                }
            }

            return result;
        }

        public int[] CountBitsFast(int num)
        {
            int[] result = new int[num + 1];
            result[0] = 0;

            for (int i = 1; i <= num; i++)
            {
                result[i] = i % 2 + result[i / 2];
            }

            return result;
        }
    }
}