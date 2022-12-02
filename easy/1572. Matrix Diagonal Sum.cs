public class Solution {
    public int DiagonalSum(int[][] mat) {
        var result = 0;
        for (int i = 0, j = mat.Length - 1; i < mat.Length; i++, j--)
        {
            if (Convert.ToString(i+i) == Convert.ToString(i+j))
            {
                result += mat[i][i];
                continue;
            }

            result += mat[i][i];
            result += mat[i][j];
        }

        return result;
    }
}