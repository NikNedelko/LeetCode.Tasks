using System;
using System.Collections.Generic;
namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Expected true \n Was:");
            System.Console.WriteLine(Solution.IsValid("()"));

            System.Console.WriteLine("Expected true \n Was:");
            System.Console.WriteLine(Solution.IsValid("()[]{}"));

            System.Console.WriteLine("Expected false \n Was:");
            System.Console.WriteLine(Solution.IsValid("(]"));

            System.Console.WriteLine("Expected false \n Was:");
            System.Console.WriteLine(Solution.IsValid("([)]"));

            System.Console.WriteLine("Expected true \n Was:");
            System.Console.WriteLine(Solution.IsValid("{[]}"));
        }
    }

    public class Solution
    {
        private static Dictionary<char, char> symbolDict = new Dictionary<char, char>()
        {
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        public static bool IsValid(string s)
        {
            s.Replace(" ", "");
            Stack<char> checker = new Stack<char>();
            foreach (var position in s)
            {
                if (symbolDict.ContainsKey(position))
                    checker.Push(symbolDict[position]);
                else if (checker.Count == 0 || checker.Pop() != position)
                    return false;
            }
            return checker.Count == 0;
        }
    }
}
