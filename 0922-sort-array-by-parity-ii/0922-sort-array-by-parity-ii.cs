public class Solution 
{
    public int[] SortArrayByParityII(int[] nums) 
    {
        int slow = 0;
        int fast = 1;
        while (fast < nums.Length && slow < nums.Length)
        {
            if (isSwap(nums[slow], slow, nums[fast], fast))
            {
                swap(nums, slow, fast);
                slow++;
                fast = slow;
            }
            else if ((nums[slow] % 2 == 0 && slow % 2 == 0) || (nums[slow] % 2 != 0 && slow % 2 != 0 ))
                slow++;
            fast++;
        }

        return nums;
        void swap(int[] nums, int slow, int fast)
        {
            int temp = nums[slow];
            nums[slow] = nums[fast];
            nums[fast] = temp;
        }

        bool isSwap(int numi, int indexi, int numj, int indexj)
        {  
            if ((numi % 2 != 0 && indexi % 2 == 0) && (numj % 2 == 0 && indexj % 2 != 0))
                return true;
            else if ((numi % 2 == 0 & indexi % 2 != 0) && (numj % 2 != 0 && indexj % 2 == 0))
                return true;
            else
                return false;
        }
    }
}