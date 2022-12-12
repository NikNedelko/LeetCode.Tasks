public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        var dict = new Dictionary<string,string>();
        foreach(var list in paths){
            dict.Add(list[0], list[1]);
        }
        var start = dict.Select(x=>x.Key).FirstOrDefault();
        while(dict.ContainsKey(start)){
            start = dict[start];
        }
        return start;
    }
}