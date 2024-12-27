public class Solution {
    public int ScoreOfString(string s) {
        var result = 0;
        for(var i = 1; i < s.Length; i++){
            var val = (int)s[i] - (int)s[i - 1];
            if(val < 0)
                val *= -1;

            result += val;
        }

        return result;
    }
}