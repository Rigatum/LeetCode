public class Solution 
{
    public int[] GetConcatenation(int[] nums) 
    {
        int x = 2;
        int i = 0;
        var ans = new int[nums.Length * x];
        
        for (int j = 0; j < ans.Length; j++)
        {
            if (i == nums.Length)
                i = 0;
            ans[j] = nums[i];
            i++;
        }
        
        return ans;
    }
}