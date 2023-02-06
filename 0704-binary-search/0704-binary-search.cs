public class Solution {
    public int Search(int[] nums, int target) 
    {
        int middle = 0;
        int begin = 0;
        int end = nums.Length - 1;

        while (begin <= end)
        {
            middle = (begin + end) / 2; 

            if (nums[middle] > target)
            {
                end = middle - 1;
            }

            else if (nums[middle] < target)
            {
                begin = middle + 1;
            }

            else return middle;
        }

        return -1;
    }
}