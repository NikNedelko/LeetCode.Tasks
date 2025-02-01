public class Solution {
    public bool IsArraySpecial(int[] nums) {
        var isEven = false;

        if(nums[0] % 2 == 0)
            isEven = true;
        
        for(var i = 1; i < nums.Length; i++){
            if(isEven == true && nums[i] % 2 == 0)
                return false;

            if(isEven == false && nums[i] % 2 != 0)
                return false;

            isEven = !isEven;
        }
        
        return true;
    }
}