public class Solution {
    public int CountGoodSubstrings(string s) {
        if(s.Length < 3) return 0;
        var result = 0;

        for(int first = 0, second = 1,third = 2; third < s.Length; first++, second++, third++){
            var hs = new HashSet<int>();
            try{
                hs.Add(s[first]);
                hs.Add(s[second]);
                hs.Add(s[third]);
            }
            catch{
            }
            if(hs.Count == 3)
                result++;
        }
        return result;
    }
}