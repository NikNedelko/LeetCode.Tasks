using System;

namespace _35._Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            Solution.SearchInsert(new int[] { 1, 2 }, 3);
            Solution.SearchInsert(new int[] { 1 }, 0);
            Solution.SearchInsert(new int[] { 1, 3}, 1);
            Solution.SearchInsert(new int[] { 1,3,5,6 }, 7);
        }
    }

    public class Solution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                    return i;
                try
                {
                    if (nums[i] < target && target <= nums[i + 1])
                        return i + 1;
                }
                catch
                {
                    return i+1;
                }
            }
            return 0;
        }
    }
}
