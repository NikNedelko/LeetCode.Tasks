public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double res = 0;
        double sum = 0;

        for (var j = 0; j < k; j++)
        {
            sum += nums[j];
        }
        res = sum / k;

        for (var i = k; i < nums.Length; i++)
        {

            sum += nums[i];
            sum -= nums[i - k];

            res = Math.Max(res, (double)sum / k);
        }

        return res;
    }
}

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var max = 0;

        for(var j = 0; j < k; j++){
            max += nums[j];    
        }

        var sum = max;

        for(var i = k; i < nums.Length; i++ ){
            sum += nums[i];
            sum -= nums[i - k];

            max = Math.Max(max, sum);
        }

        return (double)max / k;
    }
}