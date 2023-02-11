/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl 
{
    public int FirstBadVersion(int n) 
    {
        int begin = 0;
        int end = n;
        
        while (begin < end)
        {
            int middle = begin + (end - begin) / 2;
            
            if (IsBadVersion(middle))
            {
                end = middle;
            }
            else
            {
                begin = middle + 1;
            }
        }
        return begin;
    }
}