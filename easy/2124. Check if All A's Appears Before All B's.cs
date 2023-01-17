public class Solution {
    public bool CheckString(string s) {
        var change = false;
        var first = s[0];
        for(int i = 1; i < s.Length; i++){
            if(first != s[i]){
                if(change)
                    return false;
                if(s[i]=='a')
                    return false;
                first = s[i];
                change = true;
            }
        }
        return true;
    }
}