public class Solution 
{
    public int PartitionString(string s) 
    {
        int ans = 0;
        List<char> list = new();

        foreach (var letter in s)
        {
            if (list.Contains(letter))
            {
                list.Clear();
                ans++;
            }
            list.Add(letter);
        }

        return ++ans;
    }
}