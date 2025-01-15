public class Solution {
    public int DuplicateNumbersXOR(int[] nums) {
        var res = 0;
        var dict = new Dictionary<int,int>();

        foreach(var num in nums){
            if(dict.ContainsKey(num)){
                if(dict[num] == 1)
                    res ^= num;
                
                dict[num]++;
            }
            else
                dict.Add(num, 1);
        }

        return res;
    }
}