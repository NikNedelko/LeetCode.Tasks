using System;
using System.Collections.Generic;
/// <summary>
/// IN DEVELOPING
/// </summary>
namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.MergeTwoListshhhhh(new List<int> { 1, 2, 4 }, new List<int> { 1, 3, 4 });
            Solution.MergeTwoListshhhhh(new List<int> { }, new List<int> { });
            Solution.MergeTwoListshhhhh(new List<int> { }, new List<int> { 0 });
            Solution.MergeTwoListshhhhh(new List<int> { 1, 2, 4, 7, 10 }, new List<int> { 1, 3, 4 });
            ListNode list1 = new ListNode();
        }
        
    }

    public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

    public class Solution
    {
                public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

        }











































        public static List<int> MergeTwoListshhhhh(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            if (list1.Count == 0 && list2.Count != 0)
                return list2;
            else if (list2.Count == 0 && list1.Count != 0)
                return list1;
            else if (list2.Count == 0 && list1.Count == 0)
                return result;
            int i = 0, j = 0;
            while (true)
            {
                if (j >= list2.Count && i >= list1.Count)
                {
                    return result;
                }

                if (list1[i] < list2[j])
                {
                    result.Add(list1[i]);
                    if (list1.Count != i)
                        i++;
                    continue;
                }
                else if (list1[i] > list2[j])
                {
                    result.Add(list2[j]);
                    if (list2.Count != j)
                        j++;
                    continue;
                }
                else if (list1[i] == list2[j])
                {
                    result.Add(list1[i]);
                    result.Add(list2[j]);
                    if (list2.Count != j)
                        j++;
                    if (list1.Count != i)
                        i++;
                    continue;
                }
            }

            return result;
        }
    }
}
