public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
            
        var arr1 = s.ToArray();
        var arr2 = t.ToArray();
        Array.Sort(arr1);
        Array.Sort(arr2);

        for(int i = 0; i < s.Length; i ++){
            if(arr1[i] != arr2[i])
                return false;
        }

        return true;
    }
}