169. Majority Element
public class Solution {
    
    Hashtable hsTable = new Hashtable();
    
    public int MajorityElement(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        int value = 0;
        int maxCount = 0;
        
        foreach(var item in nums){
            if(!hsTable.Contains(item))
                hsTable.Add(item,0);
            else{
                int count = (int)hsTable[item];
                hsTable[item] = count +1;
            }
        }
        
        foreach(var item in nums){
            if((int)hsTable[item]>maxCount){
                value = item;
                maxCount = (int)hsTable[item];
            }
        }
        return value;
    }
}