public class Solution {
    public int MinPartitions(string n) {
        var result = '0';

        foreach(var digit in n)
        {
            if(digit > result)
            result = digit;
        }
        return result - '0';
    }
}