public class Solution 
{
    public bool PrimeSubOperation(int[] nums) 
    {
                List<int> prime_nums = new List<int>();
                for (int i = 2; i < 1000; i++)
                {
                    if(isPrime(i))
                        prime_nums.Add(i);
                }
                bool isPrime(int n)
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                            return false;
                    }
                    return true;
                }
                int p = 0;
                for (int i = 0; i < nums.Length; i++){
                    int left = 0;
                    int right = prime_nums.Count - 1;
                    while (left <= right){
                        int mid = (left + right) / 2;
                        if (prime_nums[mid] > nums[i])
                            right = mid - 1;
                        else if (prime_nums[mid] < nums[i])
                            left = mid + 1;
                        else{
                            p = mid - 1;
                            break;
                        }
                        p = left - 1;
                    }
                    if (i > 0){
                        while (p > 0 && nums[i - 1] >= nums[i] - prime_nums[p] && i >= 0  && nums[i] > prime_nums[p]){
                            p--;
                        }
                        if (p >= 0 && nums[i - 1] < nums[i] - prime_nums[p]){
                            nums[i] = nums[i] - prime_nums[p];
                        }
                    }
                    else if (p >= 0 && nums[0] > nums[0] - prime_nums[p]){
                        nums[0] = nums[0] - prime_nums[p];
                    }
                    if (i > 0 && nums[i - 1] < nums[i])
                        continue;
                    else if (i > 0)
                        return false;
                }
                return true;
    }
}