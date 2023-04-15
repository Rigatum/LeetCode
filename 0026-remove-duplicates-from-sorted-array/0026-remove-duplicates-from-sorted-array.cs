public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        HashSet<int> ans = new HashSet<int>();
        foreach (var item in nums)
        {
            ans.Add(item);
        }
        Array.Copy(ans.ToArray(), nums, ans.Count);
        return ans.Count();
}
}