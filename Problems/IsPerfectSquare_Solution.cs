namespace LeetCode.Problems
{
    public class IsPerfectSquare_Solution
    {
        public bool IsPerfectSquare(int num)
        {
            int left = 0;
            int right = num;

            while (left + 1 < right)
            {
                long mid = (long)(left + (right - left) / 2);
                        
                long square = mid * mid;

                if (square == num)
                {
                    return true;
                }

                if (square < num)
                {
                    left = (int) mid;
                }
                else
                {
                    right = (int) mid;
                }
            }

            if (left * left == num) return true;
            if (right * right == num) return true;

            return false;
        }
    }
}