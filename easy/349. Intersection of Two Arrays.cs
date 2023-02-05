public class Solution {
    //also return nums1.Intersect(nums2).ToArray();
    public int[] Intersection(int[] nums1, int[] nums2) {
        var hash1 = new HashSet<int>();
        var hash2 = new HashSet<int>();
        var list = new List<int>();

        for(int i = 0,j=0; i < nums1.Length || j < nums2.Length; i++,j++){
            if(i < nums1.Length){
                if(!hash1.Contains(nums1[i])){
                    hash1.Add(nums1[i]);
                }
            }
            if(j < nums2.Length){
                if(!hash2.Contains(nums2[j])){
                    hash2.Add(nums2[j]);
                }
            }
        }

        foreach(var numb in hash1){
            if(hash2.Contains(numb)){
                list.Add(numb);
            }
        }
        return list.ToArray();
    }
}