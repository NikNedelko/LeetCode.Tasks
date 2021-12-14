using System;

namespace _53._Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Solution.MaxSubArray(new int[] { 1 });
            Solution.MaxSubArray(new int[] { 5, 4, -1, 7, 8 });
            Solution.MaxSubArray(new int[] { });
            Solution.MaxSubArray(new int[] { });
            Solution.MaxSubArray(new int[] { });
        }
    }

    public class Solution
    {
        public static int MaxSubArray(int[] nums)
        {
            var maxEnding = nums[0];
            var maxSoFar = maxEnding;
            for (var i = 1; i < nums.Length; i++)
            {
                maxEnding = nums[i] > maxEnding + nums[i] ? nums[i] : maxEnding + nums[i];
                maxSoFar = maxSoFar > maxEnding ? maxSoFar : maxEnding;
            }
            return maxSoFar;
        }
    }
}
