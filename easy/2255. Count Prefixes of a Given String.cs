public class Solution {
    public int CountPrefixes(string[] words, string s) {
        var counter = 0;
        var firstSort = words.Where(x => x[0] == s[0]).ToArray();
        foreach(var str in firstSort){
            for(int i = 0; i < str.Length && i < s.Length; i++){
                if(str[i] != s[i])
                    break;
                if(i+1==str.Length)
                    counter++;
            }
        }
        return counter;
    }
}