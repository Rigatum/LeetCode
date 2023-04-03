public class Solution 
{
    public int NumRescueBoats(int[] people, int limit) 
    {
        int ans = 0;
        int left = 0;
        int right = people.Length - 1;

        Array.Sort(people);
        
        while(left <= right)
        {
            if(people[left] + people[right] <= limit) left++;
            
            right--;
            ans++;
        }

        return ans++;
    }
}