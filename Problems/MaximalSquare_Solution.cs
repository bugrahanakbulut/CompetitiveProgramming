using System;

namespace LeetCode.Problems
{
    public class MaximalSquare_Solution
    {
        public int MaximalSquare(char[][] matrix) 
        {
            if (matrix == null || matrix.Length == 0) 
            {
                return 0;
            }

            int answer = 0;

            int[,] dp = new int[matrix.Length, matrix[0].Length];

            for (int r = 0; r < matrix.Length; r++) 
            {
                for (int c = 0; c < matrix[0].Length; c++) 
                {
                    if (matrix[r][c] == '1')
                    {
                        dp[r, c] = '1';

                        if (r > 0 && c > 0) 
                        {
                            int rect = Math.Min(dp[r - 1, c], dp[r, c - 1]);
                            rect = Math.Min(rect, dp[r - 1, c - 1]);

                            dp[r, c] += rect;
                        }

                        answer = Math.Max(answer, dp[r, c]);
                    }
                }
            }

            return answer * answer;
        }
    }
}