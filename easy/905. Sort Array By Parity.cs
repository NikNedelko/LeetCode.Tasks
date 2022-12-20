public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        var bufer = 0;
        for(int i = 0, j = nums.Length-1; i < j;){
            if(nums[i] % 2 == 0){
                i++;
                continue;
            }
            if(nums[j] % 2 != 0){
                j--;
                continue;
            }
            if(nums[i] % 2 != 0 && nums[j] % 2 == 0){
                bufer = nums[i];
                nums[i] = nums[j];
                nums[j] = bufer;
                j--;
                i++;
            }
        }
        return nums;
    }
}