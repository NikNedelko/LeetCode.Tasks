public class Solution {
    public int FindPermutationDifference(string s, string t) {
        var dict = new Dictionary<char,int>();

        for(var i = 0; i < t.Length; i++ ){
            if(!dict.ContainsKey(t[i]))
                dict.Add(t[i], i);
        }

        var result = 0;

        for(var i = 0; i < s.Length; i++ ){
            result += Math.Abs(i - dict[s[i]]);
        }

        return result;
    }
}

