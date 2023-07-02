public class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
        HashSet<int> hs = new();
        
        foreach (int item in nums)
        {
            if (hs.Contains(item))
            {
                return true;
            }
            hs.Add(item);
        }
        return false;
    }
}