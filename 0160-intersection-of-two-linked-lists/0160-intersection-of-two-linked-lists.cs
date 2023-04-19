/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        var dummy = headA;
        ListNode ans = null;
        while (dummy != null)
        {
            dummy.val = dummy.val * -1;
            dummy = dummy.next;
        }
        
        while (headB != null)
        {
            if (headB.val < 0)
            {
                ans = headB;
                break;
            }
            headB = headB.next;
        }
        
        while (headA != null)  
        {            
            headA.val = headA.val * -1;
            headA = headA.next;
        }

        
        return ans;
    }
}