using System.Linq;
using System.Collections.Generic;

namespace LeetCodeTest.Algo
{
    public class Solution35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0; int right = nums.Length - 1;

            while(left <= right)
            {
                int count = (left + right) / 2;

                if (nums[count] == target) return count;

                if (nums[count] < target)
                    left = count + 1;
                else
                    right = count - 1;
            }

            return left;
        }
    }
}