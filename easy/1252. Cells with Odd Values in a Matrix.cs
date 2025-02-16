public class Solution {
    public int OddCells(int m, int n, int[][] indices) {
        var matrix = new int[m, n];
        var result = 0;

        foreach(var indic in indices){

            for(var i = 0; i < n; i++){
                matrix[indic[0], i]++;

                if(matrix[indic[0], i] % 2 != 0)
                    result++;
                else if(matrix[indic[0], i] != 0)
                    result--;
            }

            for(var i = 0; i < m; i++){
                matrix[i, indic[1]]++;

                if(matrix[i, indic[1]] % 2 != 0)
                    result++;
                else if(matrix[i, indic[1]] != 0)
                    result--;
            }
        }

        return result;
    }
}