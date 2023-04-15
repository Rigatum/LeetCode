public class Solution 
{
    public int NumJewelsInStones(string jewels, string stones) 
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int ans = 0;
        for (int i = 0; i < jewels.Length; i++)
        {
            dict.Add(jewels[i], i);
        }

        foreach (var item in stones)
        {
            if (dict.ContainsKey(item))
                ans++;
        }
        return ans; 
    }
}