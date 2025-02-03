public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        var result = 1;

        var countAsc = 1;
        var countDes = 1;

        for(var i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i - 1]){
                countAsc++;

                if(result < countAsc)
                    result = countAsc;
            }
            else{
                countAsc = 1;
            }

            if(nums[i] < nums[i - 1]){
                countDes++;

                if(result < countDes)
                    result = countDes;
            }
            else{
                countDes = 1;
            }
        }

        return result;
    }
}