public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        var hash1 = new HashSet<int>(nums1);
        var hash2 = new HashSet<int>(nums2);
        var result = new int[2];

        foreach (int num in nums1) {
            if (hash2.Contains(num)) {
                result[0]++;
            }
        }

        foreach (int num in nums2) {
            if (hash1.Contains(num)) {
                result[1]++;
            }
        }

        return result;
    }
}





public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        var hash1 = new HashSet<int>();
        var hash2 = new HashSet<int>();
        var result = new int[2];
        
        int i = 0, j = 0;

        while(true){
            if(i >= nums1.Length && j >= nums2.Length)
                break;

            if(i < nums1.Length){
                if(!hash1.Contains(nums1[i]))
                hash1.Add(nums1[i]);
                i++;
            }

            if(j < nums2.Length){
                if(!hash2.Contains(nums2[j]))
                hash2.Add(nums2[j]);
                j++;
            }
        }

        i = 0;
        j = 0;

        while(true){
            if(i >= nums1.Length && j >= nums2.Length)
                break;

            if(i < nums1.Length){
                if(hash2.Contains(nums1[i]))
                    result[0]++;
                
                i++;
            }

            if(j < nums2.Length){
                if(hash1.Contains(nums2[j]))
                    result[1]++;
                
                j++;
            }
        }

        return result;
    }
}