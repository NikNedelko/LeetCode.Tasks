public class Solution {
    public bool DivideArray(int[] nums) {
        var dict = new Dictionary<int,int>();
        foreach(var number in nums){
            if(!dict.ContainsKey(number)){
                dict.Add(number,1);
            }
            else{
                dict[number]++;
            }
        }
        var value = dict.FirstOrDefault(x=>x.Value % 2 != 0);
        return value.Key == 0;
    }
}