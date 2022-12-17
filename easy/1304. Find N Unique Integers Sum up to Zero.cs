public class Solution {
    public int[] SumZero(int n) {
        var array = new int[n];
        if(n % 2 != 0)
            array[n/2] = 0;
        for(int i = 0, j = array.Length -1; i < j; i++,j--){
            array[i] = (n-i);
            array[j] = array[i] * -1;
        }
        return array;
    }
}