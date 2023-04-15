public class Solution 
{
    public int[] SortArrayByParityII(int[] nums) 
    {
        int even = 0;
        int odd = 1;
        while (even < nums.Length && odd < nums.Length)
        {
            if (isEven(nums[even]))
                even += 2;
            else if (!isEven(nums[odd]))
                odd += 2;
            else swap (nums, even, odd);
        }

        return nums;

        void swap(int[] nums, int even, int odd)
        {
            int temp = nums[even];
            nums[even] = nums[odd];
            nums[odd] = temp;
        }

        bool isEven(int num)
        {  
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
    }
}