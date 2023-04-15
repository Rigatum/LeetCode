public class Solution 
{
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        int[] arr = new int[nums.Length];
        Array.Copy(nums, arr, arr.Length);
        Dictionary<int,int> dict = new Dictionary<int, int>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            dict.TryAdd(nums[i], i);  
        }

        for (int i = 0; i < nums.Length; i++)
        {
            arr[i] = dict[arr[i]];
        }
        return arr;
    }
}