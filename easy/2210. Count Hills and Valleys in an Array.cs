public class Solution {
    public int CountHillValley(int[] nums) {
        var unique = new List<int>(nums.Length);
        unique.Add(nums[0]);

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
                unique.Add(nums[i]);
        }

        var count = 0;
        
        for (var i = 1; i < unique.Count - 1; i++)
        {
            int prev = unique[i - 1], 
                curr = unique[i], 
                next = unique[i + 1];

            var isHill   = curr > prev && curr > next;
            var isValley = curr < prev && curr < next;

            if (isHill || isValley)
                count++;
        }

        return count;
    }
}