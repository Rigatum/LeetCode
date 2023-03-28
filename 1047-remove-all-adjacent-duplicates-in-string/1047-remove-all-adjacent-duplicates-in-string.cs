public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        Stack<char> stack = new Stack<char>();
        StringBuilder ans = new StringBuilder();
        char previous;
        stack.Push(s[0]);

        for (int i = 1; i < s.Length; i++)
        {
            if (stack.TryPeek(out previous) && s[i] == previous)
                stack.Pop();
            else
            {
                stack.Push(s[i]);
            }
        }
        foreach (var item in stack.Reverse())
        {
            ans.Append(item);
        }

        return ans.ToString();
    }
}