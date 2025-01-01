public class SubrectangleQueries {

    private int[][] _rectangle;

    public SubrectangleQueries(int[][] rectangle) {
        _rectangle = rectangle;
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
        for(var row = row1; row <= row2; row++){
            for(var col = col1; col <= col2; col++){
                _rectangle[row][col] = newValue;
            }
        }
    }
    
    public int GetValue(int row, int col) {
        return _rectangle[row][col];
    }
}

 public class SubrectangleQueries {

    private int[][] _rectangle;
    private List<int[]> updates = new();

    public SubrectangleQueries(int[][] rectangle) {
        _rectangle = rectangle;
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
        updates.Add(new int[]{ row1, col1, row2, col2, newValue });
    }
    
    public int GetValue(int row, int col) {
        for(var i = updates.Count - 1; i >= 0; i--){
            var update = updates[i];

            if(row >= update[0]
                                && row <= update[2] 
                                && col >= update[1] 
                                && col <= update[3]){
                return update[4];
            }
        }
        return _rectangle[row][col];
    }
}