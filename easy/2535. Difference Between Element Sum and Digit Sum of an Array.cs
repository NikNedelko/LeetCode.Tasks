public class Solution {
    public int DifferenceOfSum(int[] nums) {
        var firstSumOfNumb = 0;
        var secondSumOfNumb = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i]< 10){
                firstSumOfNumb += nums[i];
                secondSumOfNumb += nums[i];
            }
            else{

                firstSumOfNumb += nums[i];
                var numAsString = Convert.ToString(nums[i]);

                for(int j = 0; j < numAsString.Length; j++){
                    secondSumOfNumb += Convert.ToInt32(Convert.ToString(numAsString[j]));
                }
            }
        }
        return firstSumOfNumb - secondSumOfNumb;
    }
}