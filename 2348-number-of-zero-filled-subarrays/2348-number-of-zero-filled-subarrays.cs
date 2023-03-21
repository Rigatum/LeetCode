public class Solution 
{
    public long ZeroFilledSubarray(int[] nums) 
    {
        long ans = 0;
        int subzero = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
                subzero++;
            else
                subzero = 0;
            ans += subzero;
        }
        
        return ans;
    }
}