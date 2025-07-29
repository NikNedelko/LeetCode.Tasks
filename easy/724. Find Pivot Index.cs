public class Solution {
    public int PivotIndex(int[] nums) {
        var totalSum = nums.Sum(); 
        var leftSum = 0;

        for (var i = 0; i < nums.Length; i++) {

            if (leftSum == totalSum - leftSum - nums[i]) {
                return i;
            }
            
            leftSum += nums[i];
        }

        return -1;
    }
}