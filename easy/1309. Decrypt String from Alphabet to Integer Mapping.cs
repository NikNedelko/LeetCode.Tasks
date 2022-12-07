public class Solution {
    public string FreqAlphabets(string s) {
        var begin = 96;
        var sb = new StringBuilder();
        for(int i = s.Length - 1; i >= 0; i--){

            if(s[i]=='#'){
                sb.Insert(0, Convert.ToChar(Convert.ToInt32(
                    Convert.ToString(s[i-2]) + Convert.ToString(s[i-1])) + begin));
                i -= 2;
                continue;
            }
            sb.Insert(0, Convert.ToChar(Convert.ToInt32(Convert.ToString(s[i])) + begin));        
            
        }

        return sb.ToString();
    }
}