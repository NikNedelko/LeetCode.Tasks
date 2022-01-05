136. Single Number
public class Solution {
    
    public Hashtable hashTable = new Hashtable();
    
    public int SingleNumber(int[] nums) {
        int result = 0;
        foreach(var item in nums){
            if(!hashTable.Contains(item))
                hashTable.Add(item,0);
            else{
                int value = (int)hashTable[item];
                hashTable[item] = value +1;
            }
        }
        foreach(var item in nums){
            if((int)hashTable[item]==0)
                return result = (int)item;
        }
        return result;
        
    }
}