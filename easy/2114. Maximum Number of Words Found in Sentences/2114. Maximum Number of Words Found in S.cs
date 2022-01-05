2114. Maximum Number of Words Found in Sentences
public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = 0;
        for(int i = 0; i<sentences.Length; i++){
            var list = sentences[i].Split(' ');
        if(list.Length>max)
            max = list.Length;
        }
        return max;
    }
}