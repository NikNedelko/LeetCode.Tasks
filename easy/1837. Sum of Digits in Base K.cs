public class Solution {
    public int SumBase(int n, int k) {
        var result = 0;
        while (n > 0)
        {
            result +=  n % k; 
            n /= k;
        }

        return result;
    }
}