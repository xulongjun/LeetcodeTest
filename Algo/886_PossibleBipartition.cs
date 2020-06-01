using System.Linq;
using System.Collections.Generic;

namespace LeetCodeTest.Algo
{
    public class Solution886
    {
        //related to 785 Graph Bipartite
        public bool PossibleBipartition(int N, int[][] dislikes)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            foreach (var e in dislikes)
            {
                int a = e[0], b = e[1];

                if (!dict.ContainsKey(a))
                {
                    dict[a] = new List<int>();
                }

                dict[a].Add(b);

                if (!dict.ContainsKey(b))
                {
                    dict[b] = new List<int>();
                }

                dict[b].Add(a);
            }

            int[] groups = new int[N + 1];
            var list = dict.Keys.ToList();

            foreach (var k in list)
            {
                if (groups[k] == 0 && !CheckPossibility(dict, k, groups, 1))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckPossibility(Dictionary<int, List<int>> dict, int k, int[] groups, int groupNumber)
        {
            if (groups[k] != 0)
            {
                return groups[k] == groupNumber;
            }

            groups[k] = groupNumber;

            foreach (var n in dict[k])
            {
                if (!CheckPossibility(dict, n, groups, -groupNumber))
                {
                    return false;
                }
            }

            return true;
        }
    }
}