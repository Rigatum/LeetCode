public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int missingNumber = nums.Length;
        int sum1 = nums.Length;
        int sum2 = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            sum1 += i;
            sum2 += nums[i];
        }
        
        return sum1 - sum2;
    }
}