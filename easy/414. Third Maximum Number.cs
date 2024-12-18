public class Solution {
    public int ThirdMax(int[] nums) {
        Array.Sort(nums);
        var count = 1;

        for(var i = nums.Length - 2; i >= 0; i--){
            if(nums[i]< nums[i + 1]){
                count++;
            }
            if(count == 3){
                return nums[i];
            }
        }

        return nums[nums.Length - 1];
    }
}