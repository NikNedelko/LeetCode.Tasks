using System;
namespace _88._Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[] { 1, 2, 3, 0, 0, 0 };
            Solution.Merge(result, 3, new int[] { 2, 5, 6 }, 3);
            Solution.Merge(new int[] { 1 }, 0, new int[] { }, 1);
            Solution.Merge(new int[] { }, 0, new int[] { 1 }, 1);
            //  Solution.Merge(new int[]{}, ,new int[]{},);
            //Solution.Merge(new int[]{}, ,new int[]{},);
        }
    }

    public class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                }
            }
            while (n > 0)
            {
                nums1[m + n - 1] = nums2[n - 1];
                n--;
            }

        }
    }
}
