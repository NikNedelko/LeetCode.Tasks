public class Solution {
    public char RepeatedCharacter(string s) {
        var dict = new Dictionary<char,int>();
        foreach(var ch in s){
            if(!dict.ContainsKey(ch)){
                dict.Add(ch,0);
                continue;
            }
            return ch;
        }
        return 'a';
    }
}