1929. Concatenation of Array
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length*2];
        for(int i = 0,j=nums.Length;j<ans.Length;i++,j++){
            ans[i]=nums[i];
            ans[j]=nums[i];
        }
        return ans;
    }
}