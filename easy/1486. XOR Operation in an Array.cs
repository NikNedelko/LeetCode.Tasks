public class Solution {
    public int XorOperation(int n, int start) {
        var numbers = new int[n];
        for(int i = 0; i < n; i++){
            numbers[i] = start + 2 * i;
        }
        int result = 0; 
        foreach(var num in numbers){
            result ^= num;
        }
        return result;
    }
}