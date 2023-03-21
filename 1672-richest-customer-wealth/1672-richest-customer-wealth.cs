public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
    {
        int ans = -1;
        int sum = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            for(int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }
            if (sum > ans)
                ans = sum;
            sum = 0;
        }

        return ans;
    }
}