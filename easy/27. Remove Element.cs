public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var counter = 0;
        var hash = new HashSet<int>();

        for(int i = 0, j = 0; i < nums.Length; i++){
            if(nums[i] == val){
                counter++;
                hash.Add(i);
            }
            else if(hash.Count > 0){
                while(nums[j] != val && !hash.Contains(j) && j < i){
                    j++;
                }
            
                if(nums[i] != val){
                    nums[j] = nums[i];
                    hash.Add(i);
                    j++;
                }
            }
        
        }

        return nums.Length - counter;
    }

    fastest:
    public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0; 

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[count++] = nums[i];
            }
        }
        return count;
    }
}
}