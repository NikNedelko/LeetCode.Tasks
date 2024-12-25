public class Solution {
    public int MinimumOperations(int[] nums) {
        var counter = 0;

        for(var i = 0; i < nums.Length; i++){
            if(nums[i] % 3 != 0){
                var step = 1;
                while(true){
                    counter++;
                    if((nums[i] + step) % 3 == 0 || (nums[i] - step) % 3 == 0)
                        break;
                    step++;
                }
            }
        }

        return counter;
    }
}