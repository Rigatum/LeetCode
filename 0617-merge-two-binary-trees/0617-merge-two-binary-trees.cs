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

struct NodeCouple
{
    public NodeCouple(TreeNode n1, TreeNode n2)
    {
        Node1 = n1;
        Node2 = n2;
    }
    
    public TreeNode Node1 { get; }
    public TreeNode Node2 { get; }
}

public class Solution 
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) 
    {
        if (root1 is null)
            return root2;
        if (root2 is null)
            return root1;
        
        var queue = new Queue<NodeCouple>();
        
        queue.Enqueue(new NodeCouple(root1, root2));
        
        while (queue.Count > 0)
        {
            var couple = queue.Dequeue();
            var n1 = couple.Node1;
            var n2 = couple.Node2;
            
            if (n2 is null)
                continue;
            
            n1.val += n2.val;
            
            if (n1.left is null)
                n1.left = n2.left;
            else
                queue.Enqueue(new NodeCouple(n1.left, n2.left));
            
            if (n1.right is null)
                n1.right = n2.right;
            else
                queue.Enqueue(new NodeCouple(n1.right, n2.right));
        }
        
        return root1;
    }
}