public class Solution {
    public int CountKeyChanges(string s) {
        var count = 0;

        for(var i = 1; i < s.Length; i++){
            if(Char.ToLower(s[i]) != Char.ToLower(s[i - 1]))
                count++;
        }

        return count;
    }
}