public class Solution 
{
    public void SortColors(int[] nums) 
    {
        int slow = 0;
        for (int j = 0; j < 3; j++)
        {
            int fast = slow + 1;
            while (fast < nums.Length && slow < nums.Length)
            {
                if(nums[slow] == j)
                {
                    slow++;
                    fast++;
                }
                else if(nums[slow] != j && nums[fast] == j)
                {
                    swap(nums, slow, fast);
                    slow++;
                    fast++;
                }
                else
                    fast++;
            }
        }

        void swap(int[] nums, int num1, int num2)
        {
            int temp = nums[num1];
            nums[num1] = nums[num2];
            nums[num2] = temp;
        }
    }
}