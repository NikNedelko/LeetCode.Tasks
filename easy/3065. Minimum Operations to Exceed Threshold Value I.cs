public class Solution {
    public int MinOperations(int[] nums, int k) {
        var counter = 0;

        for(var i = 0; i < nums.Length; i++){
            if(nums[i] >= k)
                counter++;
        }

        return nums.Length - counter;
    }
}