public class Solution 
{
    public int NumJewelsInStones(string jewels, string stones) 
    {
        HashSet<char> hashset = new HashSet<char>();
        int ans = 0;
        for (int i = 0; i < jewels.Length; i++)
        {
            hashset.Add(jewels[i]);
        }

        foreach (var item in stones)
        {
            if (hashset.Contains(item))
                ans++;
        }
        return ans;
    }
}