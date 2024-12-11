public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0 && t.Length == 0)
            return true;

        for(int i = 0, j = 0; i < t.Length ; i++){
            if(s.Length == j)
                return true;

            if(s[j] == t[i])
                j++;

            if(s.Length == j)
                return true;
        }

        return false;
    }
}