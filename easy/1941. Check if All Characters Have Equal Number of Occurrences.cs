public class Solution {
    public bool AreOccurrencesEqual(string s) {
        var dict = new Dictionary<string,int?>();
        foreach(var word in s){
            if(dict.ContainsKey(Convert.ToString(word)))
                dict[Convert.ToString(word)]++;
            else
                dict.Add(Convert.ToString(word),0);
        } 
        int? count = null;
        foreach (var value in dict)
        {
            if (count == null)
                count = value.Value;
            if (count != value.Value)
                return false;
        }
        
        return true;
    }
}