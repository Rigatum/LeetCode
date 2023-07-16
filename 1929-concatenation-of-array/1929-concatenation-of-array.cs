public class Solution 
{
    public int[] GetConcatenation(int[] nums) 
    {
        var ans = new int[nums.Length * 2];
        int middle = nums.Length;
        
        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + middle] = nums[i];
        }
        
        return ans;
    }
}