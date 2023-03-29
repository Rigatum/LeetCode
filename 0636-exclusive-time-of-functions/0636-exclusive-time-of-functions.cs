public class Solution 
{
    public int[] ExclusiveTime(int n, IList<string> logs) 
    {          
        Stack<KeyValuePair<int,int>> stack = new();
        int[] functime = new int[n];

        foreach (var s in logs)
        {
            string[] split = s.Split(':');
            int id = int.Parse(split[0]);
            int time = int.Parse(split[2]);

            if(split[1] == "start")
            {
                if(stack.Count() != 0)
                    functime[stack.Peek().Key] += time - stack.Peek().Value; 
                stack.Push(new KeyValuePair<int, int>(id,time));
            }
            else
            {
                functime[id] += time - stack.Pop().Value + 1;
                if(stack.Count() != 0)
                    stack.Push(new KeyValuePair<int, int>(stack.Pop().Key, time + 1));
            }
        }

        return functime;
    }
}