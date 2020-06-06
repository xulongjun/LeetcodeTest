using System.Linq;
using System.Collections.Generic;
using System;

namespace LeetCodeTest.Algo
{
    public class Solution406
    {
        public class PeopleComparer : IComparer<int[]>
        {
            public int Compare(int[] a, int[] b)
            {
                if (a[0] == b[0])
                {
                    return a[1].CompareTo(b[1]);
                }
                return b[0].CompareTo(a[0]);
            }
        }

        public int[][] ReconstructQueue(int[][] people)
        {
            if (people == null || people.Length == 0)
            {
                return new int[][] { };
            }

            List<int[]> res = new List<int[]>();

            Array.Sort(people, new PeopleComparer());

            for (int i = 0; i < people.Length; i++)
            {
                res.Insert(people[i][1], people[i]);
            }

            return res.ToArray();
        }
    }
}