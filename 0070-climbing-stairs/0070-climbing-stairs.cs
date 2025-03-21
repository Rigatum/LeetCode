public class Solution 
{
    public int ClimbStairs(int n) 
    {
        return fib(n, new int[46]);
    }
    
    int fib(int n, int[] memo)
    {
        if(n < 0)
            return 0;
        if(n == 0)
            return 1;
        
        if (memo[n] == 0)
            memo[n] = fib(n-1, memo) + fib(n-2, memo);
            
        return memo[n];
    }
}