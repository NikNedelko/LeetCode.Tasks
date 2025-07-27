public class Solution {
    public int LongestSubarray(int[] nums) {
        var zeroes = 0;
        int p1 = 0, p2 = 0;

        while(p2 < nums.Length){
            if(nums[p2] == 0){
                zeroes++;
            }
            if(zeroes > 1){
                if(nums[p1] == 0)
                    zeroes--;

                p1++;
            }
            
            p2++;
        }

        return p2 - p1 - 1;
    }
}