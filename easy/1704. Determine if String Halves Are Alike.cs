public class Solution {
    public bool HalvesAreAlike(string s) {
        var checker = "aeiouAEIOU";
        var firstPice = 0;
        var secondPice = 0;
        for(int i = 0, j = s.Length/2; j < s.Length; i++, j++){
            if(checker.Contains(Convert.ToString(s[i]))){
                firstPice++;
            }

            if(checker.Contains(Convert.ToString(s[j]))){
                secondPice++;
            }
        }
        return firstPice == secondPice;
    }
} 