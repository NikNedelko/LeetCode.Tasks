public class Solution {
    public int MinOperations(int[] nums) {
         var result = 0;
        for(int i = nums.Length - 1; i > 0; i--){
            if(nums[i] < nums[i-1]){
                result += nums[i-1] - nums[i] + 1;
                nums[i] += nums[i-1] - nums[i] + 1;
                if( i != nums.Length - 1) i+=2;
            } else if(nums[i] == nums[i-1])
            {
                result += 1;
                nums[i] += 1;
                if( i != nums.Length - 1) i+=2;
            }
        }
        return result;
    }
}