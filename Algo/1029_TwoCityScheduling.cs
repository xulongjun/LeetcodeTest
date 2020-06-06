using System.Linq;
using System.Collections.Generic;
using System;

namespace LeetCodeTest.Algo
{
    public class Solution1029
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            var dic = new Dictionary<int, int>();
            var result = 0;

            for (int i = 0; i < costs.Length; i++)
                dic.Add(i, Math.Abs(costs[i][0] - costs[i][1]));

            var orderDic = dic.OrderByDescending(x => x.Value);

            int left = 0; int right = 0;

            foreach (var d in orderDic)
            {
                if (left == costs.Length / 2)
                {
                    result += costs[d.Key][1];
                }
                else if (right == costs.Length / 2)
                {
                    result += costs[d.Key][0];
                }
                else
                {
                    if(costs[d.Key][1] > costs[d.Key][0])
                    {
                        result += costs[d.Key][0];
                        left++;
                    }
                    else
                    {
                        result += costs[d.Key][1];
                        right++;
                    }
                }
            }

            return result;
        }
    }
}