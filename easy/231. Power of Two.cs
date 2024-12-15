public class Solution {
    public bool IsPowerOfTwo(int n) {
        for(int i = 0; i < 32; i++){
            if((long)Math.Pow(2, i) == n)
                return true;
        }

        return false;
    }
}

public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0) return false;
        return (n & (n - 1)) == 0;
    }
}