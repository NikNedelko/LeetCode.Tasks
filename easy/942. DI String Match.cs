public class Solution {
    public int[] DiStringMatch(string s) {
        var newArray = new int[s.Length + 1];

        for(int i = 0,l = newArray.Length - 1, j = 0; i < newArray.Length; i++){
            
            if(s.Length > i){
                if(s[i]=='D'){
                    newArray[i] = l;
                    l--; 
                    continue;
                }
                if(s[i]=='I'){
                    newArray[i] = j;
                    j++;
                    continue;
                }
            }
            newArray[i] = j;
            j++;
        }
        return newArray;
    }
}