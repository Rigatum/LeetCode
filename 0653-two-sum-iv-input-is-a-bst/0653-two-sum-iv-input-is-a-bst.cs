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
    public bool FindTarget(TreeNode root, int k) 
    {
        HashSet<int> hashSet = new();
        Stack<TreeNode> stack = new();
        stack.Push(root);
        
        while (stack.TryPop(out TreeNode node))
        {
            if (node != null)
            {
                if (hashSet.Contains(k - node.val))
                {
                    return true;
                }
                hashSet.Add(node.val);
                stack.Push(node.left);
                stack.Push(node.right);
            }
        }
        return false;
    }
}