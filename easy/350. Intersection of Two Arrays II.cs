public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        var result = new List<int>();

        for(int i = 0, j = 0; i < nums1.Length && j < nums2.Length;){
            if(nums1[i] == nums2[j]){
                result.Add(nums1[i]);
                i++;
                j++;
                continue;
            }
            if(nums1[i] < nums2[j]){
                i++;
                continue;
            }
            if(nums1[i] > nums2[j])
            {
                j++;
                continue;
            }
        }

        return result.ToArray();
    }
}

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var dict = new Dictionary<int, int>();
        var result = new List<int>();

        
        foreach (var num in nums1) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }
        }

    
        foreach (var num in nums2) {
            if (dict.ContainsKey(num) && dict[num] > 0) {
                result.Add(num);
                dict[num]--;
            }
        }

        return result.ToArray();
    }
}