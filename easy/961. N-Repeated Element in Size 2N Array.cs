public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],1);
                continue;
            }
                
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
                if(dict[nums[i]] == nums.Length/2) return nums[i];
            }
        }
        return 0;
    }
}