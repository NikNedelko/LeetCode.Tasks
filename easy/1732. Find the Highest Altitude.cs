public class Solution {
    public int LargestAltitude(int[] gain) {
        var result = 0;
        var preResult = 0;
        for(int i = 0; i < gain.Length; i++){
            preResult += gain[i];
            result = preResult > result ? preResult : result;
        }
        return result;
    }
}