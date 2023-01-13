public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
        var dict = new Dictionary<int,int>();
        foreach(var arr in items1){
            if(!dict.ContainsKey(arr[0]))
                dict.Add(arr[0],arr[1]);
            else{
                dict[arr[0]] += arr[1];
            }
        }
        foreach(var arr in items2){
            if(!dict.ContainsKey(arr[0]))
                dict.Add(arr[0],arr[1]);
            else{
                dict[arr[0]] += arr[1];
            }
        }      
        var preResult  = dict.OrderBy(x=>x.Key);
        var result = new int[dict.Count][];
        var count = 0;
        foreach(var item in preResult){
            result[count] = new int[]{item.Key, item.Value};
            count++;
        }
        return result;
    }
}