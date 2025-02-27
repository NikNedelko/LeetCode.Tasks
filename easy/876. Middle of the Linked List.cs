/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        var dict = new Dictionary<int, ListNode>();
        var count = 0;
        var cur = head;
        
        while(cur != null){
            count++;
            dict.Add(count, cur);
            cur = cur.next;
        }

        var key =  count / 2 + 1;
        return dict[key];
    }
}