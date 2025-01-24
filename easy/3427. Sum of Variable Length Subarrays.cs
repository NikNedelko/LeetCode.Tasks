public class Solution {
    public int SubarraySum(int[] nums) {
        var result = 0;

        for(var i = 0; i < nums.Length; i++){
            var subSum = 0;
            for(var j = Math.Max(0, i - nums[i]); j <= i; j++){
                subSum += nums[j];
            }

            result += subSum;
        }

        return result;
    }
}