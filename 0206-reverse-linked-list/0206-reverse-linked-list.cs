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
    public ListNode ReverseList(ListNode head) 
    {
        ListNode ans = null;
        
        while (head != null)
        {
            ans = new ListNode(head.val, ans);
            head = head.next;
        }
        return ans;
    }
}