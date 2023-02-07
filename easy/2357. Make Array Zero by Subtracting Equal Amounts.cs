public class Solution {
    public int MinimumOperations(int[] nums) {
        var zeroCount = 0;
        var iterationsNumb =0;

        while(zeroCount != nums.Length){
            zeroCount = 0;
            int? minNumber = nums.Where(x=>x > 0).DefaultIfEmpty(0).Min();
            if(minNumber!=0)
                iterationsNumb++;
            for(int i = 0; i < nums.Length; i++){
                if(nums[i]>0){
                    nums[i] -= (int)minNumber;
                }
                if(nums[i]==0){
                    zeroCount++;
                }
            }
        }

        return iterationsNumb++;
    }
}