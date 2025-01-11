public class Solution {
    public double MinimumAverage(int[] nums) {
        Array.Sort(nums);
        double result = (nums[0] + nums[nums.Length - 1]) / 2.0;

        for(int i = 1, j = nums.Length - 2; i < j; i++, j--){
            double sum = ( nums[i] + nums[j] ) / 2.0;
            if(sum < result)
                result = sum;
        }

        return result;
    }
}