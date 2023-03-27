public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        int iteration = 1;
        int word = 0;
        int letter = 0;
        int equal_letter = 0;

        List<char> list = new List<char>();

        for (int i = 0; i < strs[0].Length * strs.Length; i++)
        {
            if (i >= strs.Length * iteration)
            {
                word = 0;
                iteration++;
                letter++;
            }
            if (strs[word].Length > letter && strs[word][letter] == strs[0][letter])
            {
                equal_letter++;
            }
            else
            {
                break;
            }
            if (equal_letter == strs.Length)
            {
                list.Add(strs[word][letter]);
                equal_letter = 0;
            }
            word++;
        }

        string ans = String.Concat(list);
        return ans;
    }
}