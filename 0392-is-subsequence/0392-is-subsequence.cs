public class Solution 
{
    public bool IsSubsequence(string s, string t) 
    {
        int slow = 0;
        int fast = 0;
        int k = 0;
        while (fast < t.Length && k != s.Length)
        {
            if (s[slow] == t[fast])
            {
                k++;
                slow++;
            }
            fast++;
        }
        return k == s.Length;
    }
}