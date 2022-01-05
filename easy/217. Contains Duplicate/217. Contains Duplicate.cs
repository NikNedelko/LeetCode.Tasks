217. Contains Duplicate
public class Solution {
    
    Hashtable hsTable = new Hashtable();
    
    public bool ContainsDuplicate(int[] nums) {
        foreach(var num in nums){
            if(!hsTable.Contains(num))
                hsTable.Add(num,0);
            else
            return true;
        }
        return false;
    }
}