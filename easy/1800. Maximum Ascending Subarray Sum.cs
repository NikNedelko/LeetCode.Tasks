public class Solution {
    public int MaxAscendingSum(int[] nums) {
        var result = 0;

        for(var i = 0; i < nums.Length; i++)
        {
            var subSum = nums[i];

            for(var j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] > nums[j - 1]) 
                    subSum += nums[j];
                else
                    break;
            }
            
            if(result < subSum)
                result = subSum;
        }

        return result;
    }
}