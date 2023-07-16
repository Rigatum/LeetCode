public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        s = s.Trim();
        if (s.Length == 1 && Char.IsLetter(s[0]))
            return 1;
        int i = 0;
        
        while (s.Length != i && Char.IsLetter(s[s.Length - i - 1]))
        {
            i++;
        }
        
        return i;
    }
}