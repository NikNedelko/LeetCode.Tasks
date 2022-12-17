public class Solution {
    public int PrefixCount(string[] words, string pref) {
        return words
        .Where(x=>x.Length>=pref.Length)
        .Count(x=>x.Substring(0,pref.Length) == pref);
    }
}