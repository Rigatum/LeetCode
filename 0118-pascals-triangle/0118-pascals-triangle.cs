public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        int itr = 1;
        var ans = new List<IList<int>>();
        
        while(itr <= numRows)
        {
            List<int> row = new List<int>();
            for (int i = 0; i < itr; ++i)
            {
                if (i == 0 || i == itr - 1)
                    row.Add(1);
                else
                    row.Add(ans[itr - 2][i - 1] + ans[itr - 2][i]);    
            }
            ans.Add(row);
            ++itr;
        }
        
        return ans;
    }
}