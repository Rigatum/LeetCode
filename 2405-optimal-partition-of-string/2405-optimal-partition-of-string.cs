public class Solution 
{
    public int PartitionString(string s) 
    {
        int ans = 0;
        Dictionary<char,int> dict = new();
        char[] carr = s.ToCharArray();

        foreach (var letter in carr)
        {
            if (dict.Count != 0 && dict.ContainsKey(letter))
            {
                dict.Clear();
                dict.Add(letter, 0);
                ans++;
                continue;
            }
            else
                dict.Add(letter, 0);
        }

        if (dict.Count > 0)
            return ++ans;
        else    
            return ans;
    }
}