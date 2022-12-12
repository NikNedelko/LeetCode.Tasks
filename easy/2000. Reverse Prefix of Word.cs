public class Solution {
    public string ReversePrefix(string word, char ch) {
        var sb = new StringBuilder();
        for(int i = 0; i < word.Length; i++){
            if(word[i] == ch){
                sb.Append(word.Substring(i+1, word.Length - i-1));
                for(int j = 0; j <= i; j++){
                    sb.Insert(0, word[j]);
                }
                break;
            }
        }
        return sb.Length != 0 ? sb.ToString() : word;
    }
}