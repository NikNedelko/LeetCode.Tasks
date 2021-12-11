using System;
using System.Collections.Generic;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.TwoSum(new int[]{2,7,11,15},9);
            Solution.TwoSum(new int[]{3,2,4},6);
            Solution.TwoSum(new int[]{3,3},6);
        }
    }

    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var hash = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i==0)
                {
                    hash.Add(nums[i]);
                    continue;
                }
                for (int j = 0; j < hash.Count; j++)
                {
                    if (hash[j]+nums[i]==target)
                    {
                        result[0]=j;
                        result[1]=i;
                        return result;
                    }
                }
                hash.Add(nums[i]);
            }
            return result;
        }
    }
}
