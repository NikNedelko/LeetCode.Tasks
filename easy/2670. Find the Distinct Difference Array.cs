public class Solution {
    public int[] DistinctDifferenceArray(int[] nums) {
        var result = new int[nums.Length];

        for(var i = 0; i < nums.Length; i++){
            var pref = nums.Take(i + 1).ToHashSet(); 
            var post = nums.Skip(i + 1).ToHashSet();
            
            result[i] = pref.Count - post.Count;
        }

        return result;
    }
}