/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    public int MaxDepth(TreeNode root) 
    {
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int maxDepth = 0;
        
        if (root is null)
        {
            return 0;
        }
        
        while (queue.Count > 0)
        {
            maxDepth++;
            int length = queue.Count;
            
            for (int i = 0; i < length; i++)
            {
                if (queue.Peek().left != null)
                {
                    queue.Enqueue(queue.Peek().left);
                }
                if (queue.Peek().right != null)
                {
                    queue.Enqueue(queue.Peek().right);
                }
                queue.Dequeue();
            }
        }
        return maxDepth;
    }
}