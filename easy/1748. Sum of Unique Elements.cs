public class Solution {
    public int SumOfUnique(int[] nums) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],0);
                continue;
            }
            dict[nums[i]]++;
        }
        var unicNums = dict.Where(x=>x.Value == 0).ToList();
        var counter = 0;
        foreach(var num in unicNums){
            if(num.Value==0)
                counter += num.Key;
        }
        return counter;
    }
}