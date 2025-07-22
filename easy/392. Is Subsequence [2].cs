public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s == "")
            return true;

        var arr = s.ToCharArray(0, s.Length);
        var index = 0;

        foreach(var ch in t){
            if(arr[index] == ch){
                index++;
                if(index == s.Length)
                    return true;
            }
        }

        return false;
    }
}