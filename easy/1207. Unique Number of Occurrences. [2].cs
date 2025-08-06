public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int, int>();

        for(var i = 0; i < arr.Length; i++){
            dict[arr[i]] = dict.GetValueOrDefault(arr[i]) + 1;
        }

        var hash = new HashSet<int>();

        foreach(var val in dict.Select(x => x.Value)){
            if(!hash.Add(val))
                return false;
        }

        return true;
    }
}