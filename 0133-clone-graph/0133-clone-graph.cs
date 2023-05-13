/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution 
{
    public Node CloneGraph(Node node) 
    {
        if (node is null)
            return null;
        Dictionary<int, Node> ans = new();
        Queue<Node> queue = new();
        HashSet<int> visited = new();
        queue.Enqueue(node);
        visited.Add(node.val);
        
        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();
            
            if (!ans.ContainsKey(curr.val))
            {
                ans.Add(curr.val, new Node(curr.val));
            }
            
            foreach (var adjacentNode in curr.neighbors)
            {
                if (!visited.Contains(adjacentNode.val))
                {
                    queue.Enqueue(adjacentNode);
                    visited.Add(adjacentNode.val);
                }
                
                if (!ans.ContainsKey(adjacentNode.val))
                {
                    ans.Add(adjacentNode.val, new Node(adjacentNode.val));
                }
                
                ans[curr.val].neighbors.Add(ans[adjacentNode.val]);
            }
            
        }
        return ans[node.val];
    }
}