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
    public ListNode DeleteDuplicates(ListNode head) 
    {
        var dummy = head;
        
        while (dummy != null && dummy.next != null)
        {
            if (dummy.val == dummy.next.val)
            {
                dummy.next = dummy.next.next;
                continue;
            }
            dummy = dummy.next;
        }
        
        return head;
    }
}