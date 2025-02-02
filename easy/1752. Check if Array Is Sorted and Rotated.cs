public class Solution {
    public bool Check(int[] nums) {

        int count = 0;
        var length = nums.Length;

        for (int i = 0; i < length; i++) {
            if (nums[i] > nums[(i + 1) % length]) {
                count++;
            }
        }

        return count <= 1;
    }
}