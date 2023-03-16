public class Solution 
{
    public int MySqrt(int x) 
    {
        if (x < 2)
            return x;
        
        int begin = 1;
        int end = x;
            
        while (begin <= end)
        {
            int middle = begin + (end - begin) / 2;
            if (middle * middle == x)
                return middle;     
            else if (middle > x / middle)
                end = middle - 1;
            else 
                begin = middle + 1;
        }
        return end;
    }
}