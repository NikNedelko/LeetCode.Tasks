public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        var result = 0;

        for(var i = 0; i < words.Length; i++){
            for(var j = i + 1; j < words.Length; j++){
                if(words[i].Length > words[j].Length)
                    continue;

                if( words[i] == words[j].Substring(0, words[i].Length)
                    && words[i] == words[j].Substring(words[j].Length - words[i].Length, words[i].Length))
                    result++;
            }    
        }

        return result;
    }
}