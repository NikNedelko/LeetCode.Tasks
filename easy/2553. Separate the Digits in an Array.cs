public class Solution {
    public int[] SeparateDigits(int[] nums) {
        var result = new List<int>();

        foreach(var num in nums){
            result.AddRange(num.ToString()
                                .Select(x => x - '0')
                                .ToArray());
        }

        return result.ToArray();
    }
}