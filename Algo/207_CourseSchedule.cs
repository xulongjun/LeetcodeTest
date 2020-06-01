using System.Linq;
using System.Collections.Generic;

namespace LeetCodeTest.Algo
{
    public class Solution207
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            foreach (var e in prerequisites)
            {
                int a = e[1], b = e[0];

                if (!dict.ContainsKey(a))
                {
                    dict[a] = new List<int>();
                }

                dict[a].Add(b);
            }

            int[] visited = new int[numCourses];

            var stack = new Stack<int>();
            var list = dict.Keys.ToList();

            foreach (var k in list)
            {
                if (visited[k] == 0 && !CheckCourses(dict, k, visited, stack))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckCourses(Dictionary<int, List<int>> dict, int k, int[] visited, Stack<int> stack)
        {
            if (stack.Contains(k))
            {
                return false;
            }

            stack.Push(k);

            if (dict.ContainsKey(k))
            {
                foreach (var value in dict[k])
                {
                    if (visited[value] == 0 && !CheckCourses(dict, value, visited, stack))
                    {
                        return false;
                    }
                }

            }
            var a = stack.Pop();
            visited[a] = 1;
            return true;
        }
    }
}