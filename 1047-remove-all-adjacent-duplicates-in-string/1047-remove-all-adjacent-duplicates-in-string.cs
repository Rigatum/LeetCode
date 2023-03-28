public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        Stack<char> stack = new Stack<char>();
        string ans = "";
        char previous = 'w';
        stack.Push(s[0]);

        for (int i = 1; i < s.Length; i++)
        {
            if (stack.TryPeek(out previous) && s[i] == previous)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
                previous = stack.Peek();
            }
        }
        foreach (var item in stack.Reverse())
        {
            ans += item;
        }

        return ans;
    }
}