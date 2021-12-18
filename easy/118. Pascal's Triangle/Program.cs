using System;
using System.Collections.Generic;
namespace _118._Pascal_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.Generate(30);
            Solution.Generate(2);
            Solution.Generate(3);
            Solution.Generate(4);
            Solution.Generate(5);
        }
    }

    public class Solution
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                IList<int> builder = new List<int>();
                for (int c = 0; c <= i; c++)
                {
                    builder.Add(Convert.ToInt32( factorial(i) / (factorial(c) * factorial(i - c)))); 
                }
                result.Add(builder);
                //новая строка
            }
            return result;
        }
         private static long factorial(int n)
        {
            long i, x = 1;
            for (i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }
    }
}

