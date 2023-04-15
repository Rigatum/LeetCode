public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int ans = binarySearch(target - numbers[i], numbers, i);
            if (ans > -1)
            {
                return new int[] {++i, ++ans};
            }
        }
        return null;

        int binarySearch(int target, int[] numbers, int index)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while(left <= right)
            {
                int middle = (left + right) / 2;
                if (target > numbers[middle])
                    left = middle + 1;
                else if (target < numbers[middle])
                    right = middle - 1;
                else if (target == numbers[middle] && index == middle)
                {
                    if (numbers[middle + 1] == target)
                        return middle + 1;
                    else
                        return middle - 1;
                }
                else
                    return middle;
            }
            return -1;
        }
    }
}