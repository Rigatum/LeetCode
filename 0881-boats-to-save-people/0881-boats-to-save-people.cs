public class Solution 
{
    public int NumRescueBoats(int[] peoples, int limit) 
    {
        List<int> peoplesList = new List<int>(peoples);
        peoplesList.Sort(); 
        int ans = 0;

        while (peoplesList.Count > 1)
        {
            if (peoplesList[0] + peoplesList[peoplesList.Count - 1] <= limit)
            {
                ans++;
                peoplesList.Remove(peoplesList[0]);
                peoplesList.Remove(peoplesList[peoplesList.Count - 1]);
            }
            else
            {
                peoplesList.Remove(peoplesList[peoplesList.Count - 1]);
                ans++;
            }
        } 
        if (peoplesList.Count == 1)
        {
            return ++ans;
        }
        return ans;
    }
}