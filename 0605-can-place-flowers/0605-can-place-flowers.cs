public class Solution 
{
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        if(flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1)
        {
            return true;
        }

        int checkPlant = 0;
        for (int i = 0; i < flowerbed.Length - 1; i++)
        {
            if (flowerbed[i] == 1)
            {
                i++;
                continue;
            }
            if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
            {
                flowerbed[i] = 1;
                checkPlant++;
                i++;
            }
        }

        if (flowerbed.Length > 2 && flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0)
            checkPlant++;

        if (checkPlant >= n)
            return true;
        else
            return false;
    }
}