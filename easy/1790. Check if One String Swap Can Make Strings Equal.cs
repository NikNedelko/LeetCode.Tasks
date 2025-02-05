public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        var count = 0;
        var dict = new Dictionary<char,int>();
        var dict2 = new Dictionary<char,int>();

        for(var i = 0; i < s1.Length; i++){
            if(s1[i] == s2[i])
                count++;

            if(dict.ContainsKey(s1[i]))
                dict[s1[i]]++;
            else
                dict.Add(s1[i], 1);

            if(dict2.ContainsKey(s2[i]))
                dict2[s2[i]]++;
            else
                dict2.Add(s2[i], 1);
        }
        var isAllContains = false;

        if(dict2.All(x => dict.ContainsKey(x.Key))){
            if(dict2.All(x => dict[x.Key] == x.Value))
                isAllContains = true;
        }

        return count >= s1.Length - 2 && isAllContains;
    }
}