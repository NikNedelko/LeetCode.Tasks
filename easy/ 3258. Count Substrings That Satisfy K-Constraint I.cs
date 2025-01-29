public class Solution {
    public int CountKConstraintSubstrings(string s, int k) {
        var result = 0;

        for(var windowSize = 1; windowSize <= s.Length; windowSize++){

            for(var start = 0; start + windowSize <= s.Length; start++){
                var zero = 0;
                var one  = 0;

                for(var i = 0; i < windowSize; i++){
                    if(s[i + start] == '0')
                        zero++;
                    else
                        one++;
                }

                if(zero <= k || one <= k)
                    result++;
            }
        }

        return result;
    }
}