public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var sb = new StringBuilder();
        var maxLength = word1.Length > word2.Length ? word1.Length : word2.Length;
        for(int i = 0; i < maxLength; i++){
            if(word1.Length > i)
                sb.Append(Convert.ToString(word1[i]));
            if(word2.Length > i)
                sb.Append(Convert.ToString(word2[i]));
        }
        return sb.ToString();
    }
}