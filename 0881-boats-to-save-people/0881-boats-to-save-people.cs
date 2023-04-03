public class Solution 
{
    public int NumRescueBoats(int[] peoples, int limit) 
    {
        Array.Sort(peoples);
        int boat = 0;
        int ans = 0;
        for (int i = 0; i < peoples.Length; i++)
        {
            if (peoples[i] < limit)
            {
                if (peoples[i] == 0)
                    continue;
                boat = peoples[i];
                peoples[i] = 0;
                for (int j = peoples.Length - 1; j != 0 && boat != limit ; j--)
                {
                    if (boat + peoples[j] <= limit && peoples[j] != 0)
                    {
                        boat += peoples[j];
                        peoples[j] = 0;
                        break;
                    }   
                }
                boat = 0;
                ans++;
            }
            else
            {
                peoples[i] = 0;
                ans++;
            }
        }
        return ans;
    }
}