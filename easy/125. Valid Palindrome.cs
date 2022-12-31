public class Solution {
    public bool IsPalindrome(string s) {
        var emptyString = "";
        for(int i = 0; i < s.Length; i++){
            if(Char.IsLetter(s[i]) || Char.IsDigit(s[i]))
                emptyString+=Char.ToLower(s[i]);
            
        }
        for(int i = 0, j = emptyString.Length - 1; i < j; i++, j--){
            if(emptyString[i]!=emptyString[j])
                return false;
        }
        return true;
    }
}