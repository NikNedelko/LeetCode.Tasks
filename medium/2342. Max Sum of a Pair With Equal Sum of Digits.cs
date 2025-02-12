public class Solution {
    public int MaximumSum(int[] nums) {
        var dict = new Dictionary<int,List<int>>();
        var result = -1;

        for(var i = 0; i < nums.Length; i++){

            int num = nums[i];
            int sum = 0;

            while(num > 0){
                sum += num % 10;
                num /= 10;
            }

            if(dict.ContainsKey(sum)){
                var max = dict[sum].Max();

                if(result < max + nums[i]){
                    result = max + nums[i];
                }
                
                dict[sum].Add(nums[i]);
            }
            else
                dict.Add(sum, new() {nums[i]});
        }

        return result;
    }
}