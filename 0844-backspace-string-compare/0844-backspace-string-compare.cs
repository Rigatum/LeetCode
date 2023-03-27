public class Solution 
{
    public bool BackspaceCompare(string s, string t) 
    {
        return build(s).SequenceEqual(build(t));

        Stack<char> build(string s)
        {
            Stack<char> ans = new Stack<char>();

            foreach (var c in s.ToCharArray())
            {
                if (c != '#')
                    ans.Push(c);
                else if (ans.Count != 0)
                    ans.Pop();
            }
            return ans;
        }
    }
}