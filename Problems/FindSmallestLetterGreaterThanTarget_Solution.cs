namespace LeetCode.Problems
{
    public class FindSmallestLetterGreaterThanTarget_Solution
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int left = 0;
            int right = letters.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (mid == target)
                {
                    return letters[mid + 1];
                }

                if (letters[mid] < target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }

            return letters[left + 1];
        }
    }
}