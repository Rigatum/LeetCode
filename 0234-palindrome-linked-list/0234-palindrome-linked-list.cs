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
    public bool IsPalindrome(ListNode head) 
    {
        if (head == null || head.next == null) return true;
        var fast = head;
        ListNode prev = null;
        
        while (fast != null)
        {
            if (fast.next == null) 
            {
                head = head.next;
                break;
            }
            else
                fast = fast.next.next;
            
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        
        while (prev != null)
        {
            if (prev.val != head.val)
                return false;
            head = head.next;
            prev = prev.next;  
        }
        return true;
    }
}