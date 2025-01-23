public class Solution {
    public int AddedInteger(int[] nums1, int[] nums2) {
        var num1Min = nums1[0];
        var num2Min = nums2[0];
        
        for(var i = 0; i < nums1.Length; i++){
            if(nums1[i] < num1Min)
                num1Min = nums1[i];

            if(nums2[i] < num2Min)
                num2Min = nums2[i];
        }

        return num2Min - num1Min;
    }
}