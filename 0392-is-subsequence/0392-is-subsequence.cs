public class Solution 
{
    public bool IsSubsequence(string s, string t) 
    {
        int slow = 0;
        int fast = 0;
        int k = 0;
        while (fast < t.Length)
        {
            if (k == s.Length)
                return true;
            if (s[slow] == t[fast])
            {
                k++;
                fast++;
                slow++;
            }
            else
                fast++;
        }
        if (k == s.Length)
            return true;
        else
            return false;
    }
}