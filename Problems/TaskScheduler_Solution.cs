using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class TaskScheduler_Solution
    {
        public int LeastInterval(char[] tasks, int n) 
        {
            int[] taskFreqs = new int[26];

            foreach (char task in tasks) 
            {
                taskFreqs[task - 'A'] += 1;
            }

            Array.Sort(taskFreqs);

            int maxVal = taskFreqs[25] - 1;

            int idleCount = maxVal * n;

            for (int i = 24; i >= 0; i++) 
            {
                idleCount -= Math.Min(taskFreqs[i], maxVal);
            }

            return idleCount > 0 ? idleCount + tasks.Length : tasks.Length;
        }
    }
}