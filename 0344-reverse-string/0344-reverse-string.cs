public class Solution 
{
    public void ReverseString(char[] s) 
    {
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            swap(s, left, right);
            left++;
            right--;
        }

        void swap(char[] s, int left, int right)
        {
            char temp = ' ';
            temp = s[left];
            s[left] = s[right];
            s[right] = temp;
        }
    }
}