public class NeighborSum {

    private int[][] _grid;
    private Dictionary<int, int> AdjDict = new();
    private Dictionary<int, int> DiaDict = new();
    
    public NeighborSum(int[][] grid) {
        _grid = grid;

        for(var i = 0; i < grid.Length; i++){
            for(var j = 0; j < grid[i].Length; j++){
                var adjSum = 0;

                if(j - 1 >= 0)
                    adjSum += grid[i][j - 1];

                if(j + 1 < grid[i].Length)
                    adjSum += grid[i][j + 1];
                
                if(i - 1 >= 0)
                    adjSum += grid[i - 1][j];  

                if(i + 1 < grid.Length)
                    adjSum += grid[i + 1][j]; 

                AdjDict.Add(grid[i][j], adjSum);

                var diaSum = 0;
                
                if(j - 1 >= 0 && i - 1 >= 0)
                    diaSum += grid[i - 1][j - 1];

                if(j + 1 < grid[i].Length && i - 1 >= 0)
                    diaSum += grid[i - 1][j + 1];
                
                if(j - 1 >= 0 && i + 1 < grid.Length)
                    diaSum += grid[i + 1][j - 1];  

                if(j + 1 < grid[i].Length && i + 1 < grid.Length)
                    diaSum += grid[i + 1][j + 1]; 
                
                DiaDict.Add(grid[i][j], diaSum);
            }
        }
    }
    
    public int AdjacentSum(int value) {
        return AdjDict[value];
    }
    
    public int DiagonalSum(int value) {
        return DiaDict[value];
    }
}

/**
 * Your NeighborSum object will be instantiated and called as such:
 * NeighborSum obj = new NeighborSum(grid);
 * int param_1 = obj.AdjacentSum(value);
 * int param_2 = obj.DiagonalSum(value);
 */