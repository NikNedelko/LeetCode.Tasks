public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == original){
                i = -1;
                original *= 2;
            }
        }
        return original;
    }
}