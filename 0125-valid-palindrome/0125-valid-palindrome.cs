using System.Text.RegularExpressions;

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
                while (left < s.Length && !Char.IsLetterOrDigit(s[left]))
                    left++;
                while (right > 0 && !Char.IsLetterOrDigit(s[right]))
                    right--;
                if(left < s.Length && right >= 0 && Char.IsLetterOrDigit(s[left]) && Char.IsLetterOrDigit(s[right]) && s[right] == s[left])
                {
                    left++;
                    right--;
                    k++;
                }
                else if (left < s.Length && right >= 0 && s[right] != s[left])
                    return false;
            }
            int q = 0;
            foreach (var item in s)
            {
                if(Char.IsLetterOrDigit(item))
                    q++;
            }
            if(q == 0)
                return true;
            if (k > 0)
                return true;
            else 
                return false;
    }
}