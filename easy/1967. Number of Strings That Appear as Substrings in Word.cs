public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        var result = 0;
        for(int i = 0; i < patterns.Length; i++){
            if(word.Contains(patterns[i]))
                result++;
        }
        return result;
    }
}

||

public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        var result = 0;
        for(int i = 0; i < patterns.Length; i++){
            var curPat = patterns[i];
            var start = false;
            for(int j = 0, m = 0; j < word.Length; j++){
                if(word[j] == curPat[m]){
                    m++;
                    start = true;
                    if(m == curPat.Length)
                    {
                        result++;
                        break;
                    }
                    continue;
                }

                if (word[j] == curPat[m] || !start) continue;
                start = false;
                m = 0;
                j--;
            }
        }
        return result;
    }
}