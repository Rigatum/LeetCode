public class Solution 
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        int[] ans = new int[spells.Length];

        for (int i = spells.Length-1; i >= 0; i--)
        {
            ans[i] = BinarySearch(spells[i]);
        }
        return ans;

        int BinarySearch(int spell)
        {
            int left = 0;
            int right = potions.Length - 1;

            while(left <= right)
            {
                int mid =  left + (right - left) / 2;

                if ((long)potions[mid] * spell >= success)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return potions.Length - left;
        }
    }
}