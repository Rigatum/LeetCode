public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int max = 0;
            
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > max)
                    max = arr[j];
            }
            
            arr[i] = max;
        }
        
        if (arr.Length > 1)
            arr[arr.Length - 2] = arr[arr.Length - 1];
        arr[arr.Length - 1] = -1;
        
        return arr;
    }
}