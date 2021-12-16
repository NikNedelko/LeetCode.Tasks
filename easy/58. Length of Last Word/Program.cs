using System;

namespace _58._Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.LengthOfLastWord("a ");
            Solution.LengthOfLastWord("luffy is still joyboy");
            Solution.LengthOfLastWord("Hello ");
            Solution.LengthOfLastWord("H");
            Solution.LengthOfLastWord("Hello World s");
            Solution.LengthOfLastWord("Hello Worldss   erer             ddd");


        }
    }

    public class Solution
    {
        public static int LengthOfLastWord(string s)
        {
            int result = 0;
            int startIndex;
            bool statrPoint = false;
            if (s.Length == 1)
                return 1;
            for (int i = s.Length - 1; i >= 0; i--){
                if (statrPoint == false && char.IsLetter(s[i])){
                    startIndex = i;
                    statrPoint = true;
                }
                if (statrPoint == true){
                    if (s[i] == ' ')
                        return result;
                    if (i == 0)
                        return result + 1;
                    result++;
                }
            }
            return 0;
        }
    }
}
