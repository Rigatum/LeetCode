public class Solution 
{
    public int[] AsteroidCollision(int[] asteroids) 
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(asteroids[0]);

        for(int i = 1; i < asteroids.Length; i++)
        {
  collison: if(stack.TryPeek(out int previous) && (previous > 0  && asteroids[i] < 0))
            {
                if (Math.Abs(previous) > Math.Abs(asteroids[i]))
                    continue;
                else if (Math.Abs(previous) < Math.Abs(asteroids[i]))
                {
                    stack.Pop();
                    goto collison;
                }
                else
                    stack.Pop();
            }
            else
                stack.Push(asteroids[i]);
        }

        return stack.Reverse().ToArray();
    }
}