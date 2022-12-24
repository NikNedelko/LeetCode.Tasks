public class Solution {
    public int CountNegatives(int[][] grid) {
        var count = 0;
        foreach(var array in grid){
            count += array.Where(x => x < 0).ToList().Count;
        }
        return count;    
    }
}