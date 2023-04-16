public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        if(s.Length == 1)
            return true;
        s = s.ToLower();
        int left = 0;
        int right = s.Length - 1;
        int k = 0;
        while (left < right)
        {
            if (!Char.IsLetterOrDigit(s[left]))
                left++;
            else if (!Char.IsLetterOrDigit(s[right]))
                right--;
            else
            {
                if(s[left] != s[right])
                    return false;
                left++;
                right--;
            }
        }
        return true;
    }
}