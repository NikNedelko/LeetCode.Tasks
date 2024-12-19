public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        var hs = new bool[100];
        var result = new int[2];
        var index = 0; 

        for(var i = 0; i < nums.Length; i++){
            if(hs[nums[i]]){
                result[index++] = nums[i];
                if (index == 2) 
                    break;
            }
            else hs[nums[i]] = true;
        }

        return result;
    }
}

public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        var dict = new Dictionary<int,int>();
        var result = new int[2];
        var index = 0; 
        for(var i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
                if(dict[nums[i]] == 2){
                    result[index] = nums[i];
                    index++;
                    if(index == 2)
                        return result;
                }
            }
            else{
                dict.Add(nums[i], 1);
            }
        }

        return result;
    }
}

public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        var dict = new Dictionary<int,int>();
        var result = new List<int>();

        for(var i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
                if(dict[nums[i]] == 2)
                    result.Add(nums[i]);
            }
            else{
                dict.Add(nums[i], 1);
            }
        }

        return result.ToArray();
    }
}