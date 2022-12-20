public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        var counter = 0;
        for(int i = 0; i < nums.Length - 1; i+=2){
            counter += nums[i] > nums[i+1]? nums[i+1] : nums[i];
        }
        return counter;
    }
}