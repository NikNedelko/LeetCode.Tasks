public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var hash1 = new HashSet<int>(nums1);
        var hash2 = new HashSet<int>(nums2);

        var diff1 = hash1.Except(hash2).ToList();
        var diff2 = hash2.Except(hash1).ToList();

        return new List<IList<int>> { diff1, diff2 };
    }
}