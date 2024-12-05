public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != i)
                return nums[i] - 1;
        }

        return nums.Length;
    }
}