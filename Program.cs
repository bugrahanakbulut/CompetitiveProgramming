using System;
using LeetCode.Problems;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskScheduler_Solution sol = new TaskScheduler_Solution();

            sol.LeastInterval("AAABBBCCCDDE".ToCharArray(), 2);
            
        }
    }
}