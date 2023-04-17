public class Solution 
{
    public int MaxArea(int[] height) 
    {
        int left = 0;
        int right = height.Length - 1;
        int maxContainer = -1; 
        int shortLine = 0;

        while (right > 0 && left < height.Length)
        {
            shortLine = height[left] <= height[right] ? height[left] : height[right];
            maxContainer = (right - left) * shortLine <= maxContainer ? maxContainer : (right - left) * shortLine;
            if (height[right] == shortLine)
                right--;
            else
                left++;
        }
        return maxContainer;
    }
}