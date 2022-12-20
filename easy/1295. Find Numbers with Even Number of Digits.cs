public class Solution {
    public int FindNumbers(int[] nums) {
        var counter = 0;
        for(int i = 0; i < nums.Length; i++){
            if(Convert.ToString(nums[i]).Length % 2 == 0)
                counter++;
        }
        return counter;
    }
}