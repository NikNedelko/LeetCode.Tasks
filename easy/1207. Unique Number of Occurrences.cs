public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int,int>();
        foreach (var number in arr)
        {
            if(!dict.ContainsKey(number)){
                dict.Add(number, 0);
            }
            else{
                dict[number]++;
            }
        }
        var hash = new HashSet<int>();
        foreach (var kv in dict)
        {
            if(!hash.Contains(kv.Value)){
                hash.Add(kv.Value);
            }
            else{
                return false;
            }
        }
        return true;
    }
}