public class Solution {
    public int MinNumber(int[] nums1, int[] nums2) 
    {
        int ans = 100;
        int ans2 = 100;;

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (Convert.ToInt32(nums1[i].ToString() + nums2[j].ToString()) < ans)
                    ans = Convert.ToInt32(nums1[i].ToString() + nums2[j].ToString());

                if (nums1[i] == nums2[j] && nums1[i] < ans2)
                    ans2 = nums1[i];
            }
        }
        if (ans2 < ans)
            return ans2;
        else if (ans != 100 && ans < Convert.ToInt32((ans % 10).ToString() + (ans / 10).ToString()))
            return ans;
        else if (ans != 100 )
            return Convert.ToInt32(Convert.ToInt32((ans % 10).ToString() + (ans / 10).ToString()));
        return -1 ;
    }
}