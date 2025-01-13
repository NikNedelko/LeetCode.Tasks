public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        var count = 0;
        foreach(var ch in s)
            if(ch == '1')
                count++;

        var result = new StringBuilder();
        count--;

        for(var i = 0; i < s.Length - 1; i++){
            if(i < count)
                result.Append('1');
            else
                result.Append('0');
        }
        result.Append('1');

        return result.ToString();
    }
}