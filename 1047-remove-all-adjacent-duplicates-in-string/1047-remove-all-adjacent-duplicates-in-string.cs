public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        Stack<char> stack = new Stack<char>();
        string ans = "";
        char previous = 'w';
        if (s.Length != 0)
        {
            previous = s[0];
            stack.Push(s[0]);
        }

        for (int i = 1; i < s.Length; i++)
        {
            if (stack.TryPeek(out previous) && s[i] == previous)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
                if (stack.Count != 0)
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