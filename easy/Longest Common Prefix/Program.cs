using System;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Solution.LongestCommonPrefix(new string[] { "dog", "racecar", "car" });
            Solution.LongestCommonPrefix(new string[] { "flow", "flower", "flowight" });
            Solution.LongestCommonPrefix(new string[] { "c", "acc", "ccc" });
            Solution.LongestCommonPrefix(new string[] { "flow", "", "flowight" });
        }
    }

    public class Solution
    {
        //second sol
        public static string LongestCommonPrefix(string[] strs)
        {
            int length = strs.Length;
            if (length == 0) return "";
            if (length == 1) return strs[0];

            int count = strs[0].Length;
            string answer = strs[0];
            for (int i = 1; i < length; i++)
            {
                int strsLength = strs[i].Length;
                for (int j = 0; j < count; j++)
                {

                    if (j == strsLength || strs[i][j] != answer[j])
                    {
                        answer = answer.Substring(0, j);
                        count = answer.Length;
                        if (count == 0) return "";
                        break;
                    }
                }
            }
            return answer;
        }
    }
}
