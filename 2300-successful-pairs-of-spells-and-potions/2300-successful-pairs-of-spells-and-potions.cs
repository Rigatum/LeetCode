public class Solution 
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        var ans = new int[spells.Length];
        for (int i = spells.Length-1; i >= 0; i--)
        {
            ans[i] = Bs(spells[i]);
        }
        return ans;

        int Bs(int s)
        {
            var l = 0;
            var r = potions.Length-1;

            while (l <= r)
            {
                var m = l + (r - l) / 2;

                if (s * (long)potions[m] >= success)
                {
                    r = m-1;
                }
                else
                {
                    l = m+1;
                }
            }
            return potions.Length - l;
        }
    }
}