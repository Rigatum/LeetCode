public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int j = 0;
        if (n != 0)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = nums1[i];
                nums1[m + j] = temp;
                nums1[i] = nums2[j];
                j++;
            }
        }
        Array.Sort(nums1);
    }
}


//  i                   j
// [1,2,3,0,0,0]       [2,5,6]