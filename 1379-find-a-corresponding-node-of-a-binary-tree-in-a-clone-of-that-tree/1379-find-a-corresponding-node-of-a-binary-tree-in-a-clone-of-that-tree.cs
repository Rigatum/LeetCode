/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution 
{
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) 
    {
        Queue<TreeNode> queue = new();
        queue.Enqueue(cloned);
        
        while (queue.Count() != null)
        {
            var curr = queue.Dequeue();
            if (curr.val == target.val)
                return curr;
            if (curr.left != null)
                queue.Enqueue(curr.left);
            if (curr.right != null)
                queue.Enqueue(curr.right);
        }
        return null;
    }
}