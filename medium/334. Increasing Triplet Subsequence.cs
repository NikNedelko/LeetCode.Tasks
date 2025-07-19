public class Solution {
    public bool IncreasingTriplet(int[] nums) {
       var fVal = Int32.MaxValue;
       var sVal = Int32.MaxValue;

       for(var i = 0; i < nums.Length; i++){

        if(fVal >= nums[i]){
            fVal = nums[i];
        }
        else if(sVal >= nums[i]){
            sVal = nums[i];
        }
        else{
            return true;
        }
       }

       return false;
    }
}
