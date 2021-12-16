using System;

namespace _66._Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.PlusOne(new int[] { 1, 2, 3 });
            Solution.PlusOne(new int[] { 4, 3, 2, 1 });
            Solution.PlusOne(new int[] { 0 });
            Solution.PlusOne(new int[] { 9 });
            Solution.PlusOne(new int[]{7,2,8,4,9,4,7,0,1,1,1,7,4,0,0,6});
        }
    }

    public class Solution
    {//my
        public static int[] PlusOne(int[] digits)
        {
            string numbers = "";
            for (int i = 0; i < digits.Length; i++)
            {
                numbers += Convert.ToString(digits[i]);
            }
            ulong digitNumbers = Convert.ToUInt64(numbers);
            digitNumbers += 1;
            string check = Convert.ToString(digitNumbers);
            if (check.Length == numbers.Length)
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    digits[i] = Convert.ToInt32(Convert.ToString(check[i]));
                }
                return digits;
            }
            else
            {
                digits = new int[check.Length];
                for (int i = 0; i < digits.Length; i++)
                {
                    digits[i] = Convert.ToInt32(Convert.ToString(check[i]));
                }
                return digits;
            }
        }

        //best i found

        public int[] AnotherPlusOne(int[] digits) {
         var plus = 1;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            var digit = digits[i];
            var newDigit = digit + plus;
            if (newDigit == 10)
            {
                digits[i] = 0;
                plus = 1;
            }
            else
            {
                digits[i] = newDigit;
                plus = 0;
            }
        }
        
        if (plus == 1)
        {
            var newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            return newDigits;
        }
        return digits;
    }
    }
}
