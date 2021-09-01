using System;

namespace LeetCode.Problems
{
    public class CoinChange_Solution
    {
        private int[] _dp;

        public int CoinChange(int[] coins, int amount) 
        {
            _dp = new int[amount + 1];

            _dp[0] = 0;

            for (int i = 1; i <= amount; i++) 
            {
                _dp[i] = amount + 1;
            }

            for (int i = 0; i <= amount; i++) 
            {
                for (int c = 0; c < coins.Length; c++) 
                {
                    if (coins[c] <= i) 
                    {
                        _dp[i] = Math.Min(_dp[i], 1 + _dp[i - coins[c]]);
                    }
                }
            }

            return _dp[amount] > amount ? -1 : _dp[amount];
        }
    }
}
