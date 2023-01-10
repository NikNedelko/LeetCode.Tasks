public class Solution {

    private const int ASCII = 97;

    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        return ReturnNumber(firstWord) + ReturnNumber(secondWord) == ReturnNumber(targetWord);
    }

    private int ReturnNumber(string str){
        var number = "";
        foreach(char ch in str){
            number += Convert.ToInt32(ch) - ASCII;
        }

        return Convert.ToInt32(number);
    }
}