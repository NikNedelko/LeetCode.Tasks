public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = Enumerable.Repeat(1, nums.Length)
                               .ToArray();

        var prefix = 1;

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] *= prefix;
            prefix *= nums[i];
        }

        prefix = 1;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= prefix;
            prefix *= nums[i];
        }

        return result;
    }
}

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        result[0] = 1;

        for(var i = 1; i < nums.Length; i++){
            result[i] = result[i - 1] * nums[i - 1];
        }
        
        var prefix = 1;

        for(var i = nums.Length - 1; i >= 0; i--){
            result[i] *= prefix;
            prefix    *= nums[i];
        }

        return result;
    }
}