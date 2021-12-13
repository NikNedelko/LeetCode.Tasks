using System;
using System.Collections.Generic;
/// <summary>
/// my and best solution i found
/// </summary>
namespace Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Solution.RemoveDuplicates(arr);

            arr = new int[] { 123 };
            Solution.RemoveDuplicates(arr);

            arr = new int[] { };
            Solution.RemoveDuplicates(arr);

            arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Solution.AnotherRemoveDuplicates(arr);

        }
    }

    public class Solution
    {//my solution
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 1)
                return 1;
            int counter = nums.Length;
            int result = 0;
            var hash = new List<int>();
            foreach (var item in nums)
            {
                if (!hash.Contains(item))
                {
                    hash.Add(item);
                }
            }
            result = hash.Count;
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    nums[i] = hash[i];
                }
                catch
                {
                    nums[i] = 0;
                }
            }

            return result;
        }
// best found
        public static int AnotherRemoveDuplicates(int[] nums)
        {
            if (nums.Length > 1)
            {
                var count = 1;
                for (var i = 1; i < nums.Length; i++)
                {
                    if (nums[i - 1] != nums[i])
                    {
                        nums[count] = nums[i];
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return nums.Length;
            }
        }
    }
}
