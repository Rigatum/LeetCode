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
    public int GetDecimalValue(ListNode head) 
    {
        int sum = 0;
        int i = 0;
        
        ListNode prev = null;
        
        while (head != null)
        {
            var next = head.next; 
            head.next = prev;
            prev = head;
            head = next;
        }
        
        while (prev != null)
        {
            sum += prev.val * (int)Math.Pow(2, i);
            i++;
            prev = prev.next;
        }
        return sum;
    }
}