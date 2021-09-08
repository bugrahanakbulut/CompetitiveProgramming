using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class FindKClosestElements_Solution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int n = arr.Length - 1;
            IList<int> result = new List<int>();

            if (arr == null || n == 0)
            {
                return result;
            }

            int left = 0;
            int right = n - k;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (x - arr[mid] > arr[mid + k] - x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            
            for (int i = left; i < left + k; i++) 
            {
                result.Add(arr[i]);
            }
            
            return result;
        }
    }
}