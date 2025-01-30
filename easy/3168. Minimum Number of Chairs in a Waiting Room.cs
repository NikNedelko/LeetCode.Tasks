public class Solution {
    public int MinimumChairs(string s) {
        var count = 0;
        var maxCount = 0;
        
        foreach(var ch in s){
            if(ch == 'E'){
                count++;
            }
            else
                count--;

            if(maxCount < count)
                maxCount = count;
        }

        return maxCount;
    }
}