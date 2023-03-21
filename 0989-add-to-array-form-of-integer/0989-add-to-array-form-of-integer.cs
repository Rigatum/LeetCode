public class Solution 
{
    public IList<int> AddToArrayForm(int[] num, int k) 
    {
        List<int> ans = new List<int>();

        int cur = k;
        int i = num.Length;

        while(--i >= 0 || cur > 0)
        {
            if (i >= 0)
                cur += num[i];
            ans.Add(cur % 10);
            cur /= 10;
        }

        ans.Reverse();

        return ans;
    }
}