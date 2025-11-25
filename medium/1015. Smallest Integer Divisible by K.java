public class Solution {
    public int SmallestRepunitDivByK(int k) {
        if(k % 2 == 0 || (k * 2) % 10 == 0)
            return -1;

        var n = (0 * 10 + 1) % k;
        var loops = 1;
        while(true){
            if(n == 0)
                break;

            n = (n * 10 + 1) % k;

            loops++;
        }

        return loops;   
    }
}