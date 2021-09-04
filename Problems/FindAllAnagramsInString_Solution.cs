using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class FindAllAnagramsInString_Solution
    {
        public IList<int> FindAnagrams(string s, string p) 
        {
            List<int> result = new List<int>();

            if (s == null || s.Length == 0) 
            {
                return result;
            }

            int[] charCount = new int[26];

            foreach (char c in p) 
            {
                charCount[c - 'a']++;
            }

            int left = 0;
            int right = 0;
            int windowSize = p.Length;
            
            while(right < s.Length) 
            {
                if (charCount[s[right] - 'a'] >= 1) 
                {
                    charCount[s[right] - 'a']--;
                    right++;
                    windowSize--;
                }

                if (windowSize == 0) 
                {
                    result.Add(left);
                }

                if (right - left == p.Length && charCount[s[left] - 'a'] >= 0) 
                {
                    left++;
                    windowSize++;
                    charCount[s[left] - 'a']++;
                }
            }

            return result;
        }
    }
}