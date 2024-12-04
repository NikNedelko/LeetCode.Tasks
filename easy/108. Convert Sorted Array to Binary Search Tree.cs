/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length == 0)
        {
            return null;
        }

        var midIndex = (nums.Length) / 2;
        var tree = new TreeNode(nums[midIndex]);

        var left = new int[midIndex];
        for (int i = 0; i < midIndex; i++)
        {
            left[i] = nums[i];
        }

        tree.left = SortedArrayToBST(left);

        var right = new int[nums.Length - (left.Length + 1)];
        for (int i = 0; (i + midIndex + 1) < nums.Length; i++)
        {
            right[i] = nums[i + midIndex + 1];
        }

        tree.right = SortedArrayToBST(right);

        return tree;
    }
}