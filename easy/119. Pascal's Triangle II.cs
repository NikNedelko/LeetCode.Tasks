public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var list1 = new int[]{1,1};
        var list2 = new int[]{1};

        for(int i = 1; i <= rowIndex; i++){

            list2 = new int[i + 1];
            list2[0] = 1;
            list2[list2.Length - 1] = 1;

            for(int j = 1; j < list2.Length - 1; j++){
                list2[j] = list1[j - 1] + list1[j]; 
            }

            if(i + 1 <= rowIndex)
                list1 = list2;
        }

        return list2;
    }
}

best:

public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var row = new List<int> { 1 }; // Start with the first row [1]
        for (int i = 1; i <= rowIndex; i++) {
            for (int j = row.Count - 1; j > 0; j--) {
                row[j] = row[j] + row[j - 1]; // Update current element
            }
            row.Add(1); // Add 1 at the end of the row
        }
        return row;
    }
}