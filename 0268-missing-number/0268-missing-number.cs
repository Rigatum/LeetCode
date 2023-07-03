public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int missingNumber = nums.Length;
        
        for (int i = 0; i < nums.Length; i++)
        {
            missingNumber ^= i ^ nums[i];
        }
        
        return missingNumber;
    }
}