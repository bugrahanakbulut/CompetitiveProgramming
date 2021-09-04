namespace LeetCode.Problems
{
    public class CountingBit_Solution
    {
        public int[] CountBits(int n) 
        {
            int[] resArr = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                resArr[i] = CountBitsNumber(i);
            }

            return resArr;
        }

        private int CountBitsNumber(int n) 
        {
            int tmp = n;
            int res = 0;
            
            while (tmp > 0) 
            {
                res += tmp % 2;
                tmp = tmp >> 1;
            }

            return res;
        }
    }
}