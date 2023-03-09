public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();

        for(int i = 1; i <= numRows; i++)
        {
            var priviousList = result.Count > 1 
                ? result[result.Count-1] 
                : null;
            var preResult = new List<int>();

            for(int j = 0; j < i; j++)
            {
                if(j == 0){
                    preResult.Add(1);
                    continue;
                }

                if(j == i-1){
                    preResult.Add(1);
                    continue;
                }

                preResult.Add(priviousList[j] + priviousList[j-1]);
            }

            result.Add(preResult);
        }
        
        return result;
    }
}