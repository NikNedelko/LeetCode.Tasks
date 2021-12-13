using System;
using System.Collections.Generic;
namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.RomanToInt("III");
            Solution.RomanToInt("LVIII");
            Solution.RomanToInt("IV");
            Solution.RomanToInt("IX");
        }
    }

    public class Solution
    {
        private static Dictionary<char, int> RomanDictionary = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
        public static int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result += RomanDictionary[s[i]];
            }
            if (s.Contains("IV") || s.Contains("IX"))
                result -= 2;
            if (s.Contains("XL") || s.Contains("XC"))
                result -= 20;
            if (s.Contains("CD") || s.Contains("CM"))
                result -= 200;
            if (result > 3999)
                return 0;
            return result;
        }

        public static int SecondRomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && RomanDictionary[s[i]] < RomanDictionary[s[i + 1]])
                {
                    result -= RomanDictionary[s[i]];
                }
                else
                {
                    result += RomanDictionary[s[i]];
                }
            }
            return result;
        }
    }
}
