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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null)
            return head;
       var dict = new Dictionary<int,int>();
        var list = new List<ListNode>();
        var newListNode = head;
        var current = head;
        while(true){
            if(!dict.ContainsKey(current.val)){
                dict.Add(current.val,0);
                list.Add(current);
            }
            if(current.next == null)
                break;
            current = current.next;
        }
        var bufer = list[0];
        list.RemoveAt(0);

        for (int i = 0; i < list.Count; i++)
        {
            bufer.next = list[i];
            bufer = bufer.next;
            if (i + 1 == list.Count)
            {
                
            }
        }
        bufer.next = null;
        return newListNode;
    }
}