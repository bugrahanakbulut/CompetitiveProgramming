namespace LeetCode.Problems
{
    public class Search2DMatrixII_Solution
    {
        public bool SearchMatrix(int[][] matrix, int target) 
        {
            int n = matrix.Length;
            int m = matrix[0].Length;

            int row = 0;
            int col = m - 1;

            while (col >= 0 && row < n) 
            {
                if (matrix[row][col] == target) 
                {
                    return true;
                }

                if (matrix[row][col] > target) 
                {
                    col--;
                    continue;
                }

                if (matrix[row][col] < target) 
                {
                    row++;
                    continue;
                }
            }

            return false;
        }
    }
}