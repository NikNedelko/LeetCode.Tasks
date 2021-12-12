using System;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.IsPalindrome(121);
            Solution.IsPalindrome(-121);
            Solution.IsPalindrome(144421);
            Solution.IsPalindrome(0);
            Solution.IsPalindrome(3242342);
        }
    }

    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            System.Console.WriteLine(x);
            if (x < 0)
                return false;
            int y = 1;
            while (x / y >= 10) // = 10 - избежать 10000 подобных
                y *= 10;// Расширяем один бит, добавляем 0
            while (x > 0)
            {
                int left = x / y;// Номер слева
                int right = x % 10;// Правильный номер
                if (left != right){
                    System.Console.WriteLine("false");
                    return false;
                }
                x = (x % y) / 10;// отломаем оба конца
                y /= 100;// Исходное число минус две цифры, тогда y также уменьшается на две цифры
            }
            System.Console.WriteLine("true");
            return true;
        }
    }
}
