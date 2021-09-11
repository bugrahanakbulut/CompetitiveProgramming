using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    public class IntersectionOfTwoArrays_Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>(nums1);

            HashSet<int> intersection = new HashSet<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (set.Contains(nums2[i]))
                {
                    intersection.Add(nums2[i]);
                }
            }

            return intersection.ToArray();
        }
    }
}