public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        for(var i = 0; i < k; i++){
            var minValue = 0;
            for(var j = 1; j < nums.Length; j++){
                if(nums[minValue] > nums[j])
                    minValue = j;
            }
            nums[minValue] *= multiplier;
        }

        return nums;
    }
}