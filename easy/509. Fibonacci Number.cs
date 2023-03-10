public class Solution {
    private int[] fibNumbers = new int[32];

    public int Fib(int n) {
        if(n <= 1) return n;

        if(fibNumbers[n] > 0){
            return fibNumbers[n];
        }
        
        fibNumbers[n] = Fib(n-1) + Fib(n-2);

        return fibNumbers[n];
    }
}