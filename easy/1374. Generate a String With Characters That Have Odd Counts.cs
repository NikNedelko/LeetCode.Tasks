public class Solution {
    public string GenerateTheString(int n) {
        return n % 2 == 0 
        ? new string('a', n - 1) + 'b'
        : new string('a', n);
    }
}