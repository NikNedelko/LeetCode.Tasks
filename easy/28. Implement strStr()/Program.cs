using System;
using System.Linq;

namespace _28._Implement_strStr__
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.StrStr("hello", "l");
            Solution.StrStr("aaaaa", "bba");
            Solution.StrStr("a", "a");
        }
    }

    public class Solution
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack == "" && needle == "" || needle == "")
                return 0;
            if (haystack == needle)
                return 0;

            int result = haystack.IndexOf(needle);
            return result;
        }
    }
}
