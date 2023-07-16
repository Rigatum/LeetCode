public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = arr[arr.Length - 1];
        arr[arr.Length - 1] = -1;
        
        for (int i = arr.Length - 2; i >= 0; i--)
        {
            int temp = max;
            if (arr[i] > max)
                max = arr[i];
            arr[i] = temp;
        }
        
        return arr;
    }
}