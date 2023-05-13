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
    public int MinDepth(TreeNode root) 
    {
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int minDepth = 0;
        
        if (root == null)
        {
            return 0;
        }
        
        while (queue.Count > 0)
        {
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
                if (queue.Peek().left == null && queue.Peek().right == null)
                {
                    return ++minDepth;
                }
                queue.Dequeue();
            }
            minDepth++;
        }
        return minDepth;
    }
}