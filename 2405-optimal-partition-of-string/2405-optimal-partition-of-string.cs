public class Solution 
{
    public int PartitionString(string s) 
    {
        int ans = 0;
        List<char> list = new();

        foreach (var letter in s)
        {
            if (list.Count != 0 && list.Contains(letter))
            {
                list.Clear();
                list.Add(letter);
                ans++;
                continue;
            }
            else
                list.Add(letter);
        }

        if (list.Count > 0)
            return ++ans;
        else    
            return ans;
    }
}