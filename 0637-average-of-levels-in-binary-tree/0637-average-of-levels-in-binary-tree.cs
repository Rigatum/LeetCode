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
    public IList<double> AverageOfLevels(TreeNode root) 
    {
        Queue<TreeNode> queue = new();
        List<double> ans = new();
        queue.Enqueue(root);
        double sum = 0;
        
        while (queue.Count > 0)
        {            
            int length = queue.Count();
            for (int i = 0; i < length; i++)
            {
                sum += queue.Peek().val;
                
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
            ans.Add(sum / length);
            sum = 0;
        }
        return ans;
    }
}