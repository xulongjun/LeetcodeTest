using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeTest.Algo
{
    public class Solution957
    {
        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            Dictionary<string, int> seen = new Dictionary<string, int>();
            int remainDay = 0;

            for (int day = 1; day <= N; day++)
            {
                cells = getNextDay(cells);
                string key = string.Join("", cells);

                if (seen.ContainsKey(key))
                {
                    int cycle = day - seen[key];
                    remainDay = (N - day) % cycle + seen[key];
                    var res = seen.FirstOrDefault(x => x.Value == remainDay).Key;
                    cells = res.Select(c => c - '0').ToArray();
                    break;
                }
                else
                {
                    seen.Add(key, day);
                }
            }

            return cells;
        }

        private int[] getNextDay(int[] state)
        {
            int[] next = new int[state.Length];
            next[0] = 0;
            next[state.Length - 1] = 0;

            for (int i = 1; i < state.Length - 1; i++)
            {
                next[i] = state[i - 1] == state[i + 1] ? 1 : 0;
            }

            return next;
        }
    }
}
