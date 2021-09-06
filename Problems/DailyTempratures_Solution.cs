using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class DailyTempratures_Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] res = new int[temperatures.Length];

            Stack<int> tmpStack = new Stack<int>();

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (tmpStack.Count > 0 && temperatures[tmpStack.Peek()] < temperatures[i])
                {
                    int day = tmpStack.Pop();
                    
                    res[day] = i - day;
                }
                
                tmpStack.Push(i);
            }

            return res;
        }
    }
}