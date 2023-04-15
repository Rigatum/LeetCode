public class Solution 
{
    public IList<int> PartitionLabels(string s) 
    {
        List<int> ans = new List<int>() {-1}; 
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int portion = -1;
        int j = 0;

        for (int i = s.Length - 1; i >= 0 ; i--)
        {
            dict.TryAdd(s[i], i);
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]) && dict[s[i]] > ans[j])
            {
                portion = dict[s[i]];
                ans.RemoveAt(j);
                ans.Insert(j, dict[s[i]]);
            }

            if (portion == i)
            {
                j++;
                ans.Add(-1);
                continue;
            }
        }
        ans.RemoveAt(ans.Count - 1);
        for (int i = ans.Count - 1; i != 0; i--)
        {
            ans[i] = ans[i] - ans[i - 1];
        }
        ans[0]++;
        return ans;
    }
}