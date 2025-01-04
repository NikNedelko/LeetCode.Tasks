public class Solution {
    public bool IsBalanced(string num) {
        var sum = 0;

        for(var i = 0; i < num.Length; i++){
            if(i % 2 == 0)
                sum += num[i] - '0';
            else
                sum -= num[i] - '0';
        }

        return sum == 0;
    }
}