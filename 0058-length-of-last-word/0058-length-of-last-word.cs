public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        s = s.TrimEnd();
        string[] ans = s.Split(' ');
        return ans[ans.Length -1].Length;
    }
}