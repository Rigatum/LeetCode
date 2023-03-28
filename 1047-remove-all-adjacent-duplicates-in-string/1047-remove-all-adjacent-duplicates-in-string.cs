public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        Stack<char> stack = new Stack<char>();
        StringBuilder sb = new StringBuilder();
        char previous;
        stack.Push(s[0]);
        sb.Append(s[0]);

        for (int i = 1; i < s.Length; i++)
        {
            if (stack.TryPeek(out previous) && s[i] == previous)
            {
                stack.Pop();
                sb.Remove(sb.Length - 1, 1);
            }
            else
            {
                stack.Push(s[i]);
                sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}