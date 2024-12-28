public int LengthOfLongestSubstring(string s) {
        var hash = new HashSet<char>();
        var res  = 0;
        for(var windowSize = 1; windowSize <= s.Length; windowSize++)
        {
            for(var i = 0; i + windowSize  <= s.Length; i++)
            {
                for (var range = 0; range < windowSize; range++)
                {
                    if(hash.Contains(s[i + range])){
                        
                        break;
                    }
                    if(!hash.Contains(s[i + range])){
                        hash.Add(s[i + range]);
                    }
                }
                if(res < hash.Count)
                    res = hash.Count;
                hash.Clear();
            }
        }

        return res;
    }

    public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hash = new HashSet<char>();
        int start = 0, maxLength = 0;

        for (var end = 0; end < s.Length; end++) {
            while (hash.Contains(s[end])) {
                hash.Remove(s[start]);
                start++;
            }

            
            hash.Add(s[end]);
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}