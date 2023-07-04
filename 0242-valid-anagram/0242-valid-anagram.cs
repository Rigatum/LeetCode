public class Solution 
{ 
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;
        
        var dict = new Dictionary<char,int>();
        
        for (int i = 0; i< s.Length; i++)
        {
            dict.TryAdd(s[i], 0);
            dict.TryAdd(t[i], 0);
            
            dict[s[i]]++;
            dict[t[i]]--;
        }
        
        return dict.Values.All(d => d == 0);
    }
}