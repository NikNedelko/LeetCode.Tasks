public class Solution {
    public string RemoveTrailingZeros(string num) {
        for(var i = num.Length - 1; i >= 0; i--){
            if(num[i] != '0')
                return num.Substring(0, i + 1);
        }

        return num;
    }
}