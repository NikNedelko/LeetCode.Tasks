public class Solution {
    public int MaxProduct(int[] nums) {
        var firstValue = 0;
        var secondValue = 0;
        var index = 0;
        if(nums[0] > nums[1]){
            firstValue = nums[0];
            secondValue= nums[1];
            index = 0;
        }
        else{
            firstValue = nums[1];
            secondValue= nums[0];
            index = 1;
        }

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > firstValue){
                secondValue = firstValue;
                firstValue = nums[i];
                index = i;
            }
            else if(secondValue < nums[i] && i != index){
                secondValue = nums[i];
            }
        }
        
        return (firstValue - 1) * (secondValue - 1);  
    }
}