public class Solution {
    public int LargestAltitude(int[] gain) {
        var result = Math.Max(0, gain[0]);
        
        for(var i = 1; i < gain.Length; i++){
            gain[i] = gain[i - 1] + gain[i];
            result = Math.Max(result, gain[i]);
        }

        return result;
    }
}