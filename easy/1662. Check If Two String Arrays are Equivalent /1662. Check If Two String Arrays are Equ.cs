1662. Check If Two String Arrays are Equivalent
public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        foreach(var item in word1)
            sb1.Append(item);
        foreach(var item in word2)
            sb2.Append(item);
        var res1=sb1.ToString();
        var res2=sb2.ToString();
        return res1==res2;
    }
}