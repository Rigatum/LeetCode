/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution 
{
    public bool HasCycle(ListNode head) 
    {
        var walker = head;
        var runner = head;
        while (head != null && runner.next != null && runner.next.next != null)
        {
            walker = walker.next;
            runner = runner.next.next;
            if (walker == runner)
                return true;
        }
        return false;
    }
}