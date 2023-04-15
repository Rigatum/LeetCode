public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right)
        {
            if (numbers[left] + numbers[right] == target)
                return new int[] {++left, ++right};
            else if (numbers[left] + numbers[right] < target)
                left++;
            else 
                right--;
        }
        return null;
    }
}