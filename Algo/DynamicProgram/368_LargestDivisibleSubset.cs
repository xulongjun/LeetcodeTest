using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Algo.DynamicProgram
{
    class Solution368
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            if (nums == null || nums.Length == 0) return new List<int>();

            var res = new List<int>();

            int[] SolutionIndex = new int[nums.Length];
            int[] Temp = new int[nums.Length];

            for (int i = 0; i < Temp.Length; i++)
                Temp[i] = 1;

            int max_ind = 0;

            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if(nums[i] % nums[j] == 0 && Temp[j] + 1 > Temp[i])
                    {
                        SolutionIndex[i] = j + 1;
                        Temp[i] = Temp[j] + 1;
                    }
                }

                if (Temp[i] > Temp[max_ind])
                    max_ind = i;
            }

            while (max_ind >=0)
            {
                res.Add(nums[max_ind]);
                max_ind = SolutionIndex[max_ind] - 1;
            }

            res.Reverse();

            return res;
        }
    }
}
