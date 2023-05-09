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
    public int RangeSumBST(TreeNode root, int low, int high) 
    {
        Stack<TreeNode> stack = new();
        stack.Push(root);
        int ans = 0;
        while (stack.TryPop(out TreeNode node))
        {
            if (node != null)
            {
                if (low <= node.val && node.val <= high)
                {
                    ans += node.val;
                    Console.Write(ans);
                }
                if (low < node.val)
                {
                    stack.Push(node.left);
                }
                if (node.val < high)
                {
                    stack.Push(node.right);
                }                 
            }
        }
        return ans;
    }
}