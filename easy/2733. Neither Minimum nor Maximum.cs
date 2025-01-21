public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        Array.Sort(nums);
        if(nums.Length <= 2)
            return -1;

        return nums[nums.Length / 2];
    }
}