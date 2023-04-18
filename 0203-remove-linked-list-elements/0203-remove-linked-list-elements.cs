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
public class Solution 
{
    public ListNode RemoveElements(ListNode head, int val) 
    {
        var dummy = head;
        
        while (dummy != null && dummy.next != null)
        {
            if (dummy.next.val == val)
                dummy.next = dummy.next.next;
            else
                dummy = dummy.next;
        }
        if (head != null && head.val == val)
            head = head.next;
        return head;
    }
}