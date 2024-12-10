public class Solution {
    public bool IsIsomorphic(string s, string t) {      
        if(s.Length != t.Length) 
        return false;

        var dict1 = new Dictionary<int,int>();
        var dict2 = new Dictionary<int,int>();
        
        for(int i = 0; i < s.Length; i++){
            if (dict1.ContainsKey(s[i]) && dict1[s[i]] != t[i]) 
                return false;

            if (dict2.ContainsKey(t[i]) && dict2[t[i]] != s[i]) 
            return false;

            dict1[s[i]] = t[i];
            dict2[t[i]] = s[i];
        }

        return true;
    }
}


