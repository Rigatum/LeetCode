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
        var lengthA = headA;
        var lengthB = headB;
        int a = 0;
        int b = 0;
        
        while (lengthA != null)
        {
            lengthA = lengthA.next;
            a++;
        }
        
        while (lengthB != null)
        {
            lengthB = lengthB.next;
            b++;
        }
        
        if (a > b)
        {
            while (a != b)
            {
                headA = headA.next;
                a--;
            }
        }
        else if (a < b)
        {
            while (a != b)
            {
                headB = headB.next;
                b--;
            }
        }
        
        while (headA != null)
        {
            if (headA == headB)
                return headA;
            headA = headA.next;
            headB = headB.next;
        }
        return null;
    }
}