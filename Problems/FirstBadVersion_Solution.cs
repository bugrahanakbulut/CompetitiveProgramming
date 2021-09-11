namespace LeetCode.Problems
{
    public class FirstBadVersion_Solution
    {
        public int FirstBadVersion(int n)
        {
            int left = 0;
            int right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (IsBadVersion(mid))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private bool IsBadVersion(int n)
        {
            return false;
        }
    }
}