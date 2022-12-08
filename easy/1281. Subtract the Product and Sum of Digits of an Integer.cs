public class Solution {
    public int SubtractProductAndSum(int n) {
        var stringN = Convert.ToString(n);
        var productOfDigits = 1;
        var sumOfDigits = 0;
        for(int i = 0; i < stringN.Length; i++){
            productOfDigits *= Convert.ToInt32(Convert.ToString(stringN[i]));
            sumOfDigits += Convert.ToInt32(Convert.ToString(stringN[i]));
        }
        return productOfDigits - sumOfDigits;
    }
}