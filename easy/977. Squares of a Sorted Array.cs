public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(int i = 0; i < nums.Length; i++){
            nums[i] *= nums[i];
        }
        return nums.OrderBy(x=>x).ToArray();
    }
}