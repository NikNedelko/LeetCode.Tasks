public class Solution {
    public bool CheckIfPangram(string sentence) {
        var dict = new Dictionary<char,int>();
        for(int i = 0; i < sentence.Length; i++){
            if(!dict.ContainsKey(sentence[i])){
                dict.Add(sentence[i],0);
                continue;
            }
        }
        return dict.Count() >= 26;
    }
}