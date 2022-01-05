219. Contains Duplicate II
public class Solution {
    public Hashtable hsTable = new Hashtable();
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        if(nums.Length == 1 || k == 0)
            return false;
        for(int i = 0;i< nums.Length;i++){
            if(hsTable.Contains(nums[i]))
               return true;
            else{
                if(i>=k){
                    hsTable.Remove(nums[i-k]);
                }
                hsTable.Add(nums[i],0);
            }
        }
        return false;
    }
}