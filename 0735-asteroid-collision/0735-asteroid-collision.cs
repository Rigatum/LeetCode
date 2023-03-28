public class Solution 
{
    public int[] AsteroidCollision(int[] asteroids) 
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(asteroids[0]);
        int j = 1;
        for(int i = 1; i < asteroids.Length; i++)
        {
            if(stack.TryPeek(out int previous) && (previous > 0  && asteroids[i] < 0))
            {
                if (Math.Abs(previous) > Math.Abs(asteroids[i]))
                    continue;
                else if (Math.Abs(previous) < Math.Abs(asteroids[i]))
                {
                    stack.Pop();
                    stack.Push(asteroids[i]);

                    while(j < stack.Count)
                    {
                        if ((stack.Peek() < 0 && stack.ElementAt(j) > 0))
                        {
                            if (Math.Abs(stack.Peek()) > Math.Abs(stack.ElementAt(j)))
                            {
                                stack.Pop();
                                stack.Pop();
                                stack.Push(asteroids[i]);
                            }
                            else if (Math.Abs(stack.Peek()) < Math.Abs(stack.ElementAt(j)))
                            {
                                stack.Pop();
                                break;
                            }
                            else
                            {
                                stack.Pop();
                                stack.Pop();
                                break;
                            }
                        }
                        else
                            break;
                    }
                }
                else
                    stack.Pop();
            }
            else
                stack.Push(asteroids[i]);
        }

        int[] ans = stack.Reverse().ToArray();
        return ans;
    }
}