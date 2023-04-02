public class Solution 
{
    public IList<IList<int>> FindMatrix(int[] nums) 
    {
        List<IList<int>> ans = new List<IList<int>>();
        List<int> list = new List<int>();

        while(sumarray(nums) != 0)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if ((list.Count == 0 || !list.Contains(nums[i])) && nums[i] > 0)
                {
                    list.Add(nums[i]);
                    nums[i] = 0;
                }
            }
            ans.Add(list);
            list = new List<int>();
        }

        return ans;
    }

    public int sumarray(int[] nums)
    {
        int sum = 0;
        foreach (int item in nums) {
            sum += item;
        }

        return sum;
    }
}