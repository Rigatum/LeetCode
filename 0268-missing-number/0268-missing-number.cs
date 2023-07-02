public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        HashSet<int> hs = new(nums);
        
        for (int i = 0; i < nums.Length + 1; i++)
        {
            if (!hs.Contains(i))
            {
                return i;
            }
        }
        return -1;
    }
}