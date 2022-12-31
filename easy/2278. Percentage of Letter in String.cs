public class Solution {
    public int PercentageLetter(string s, char letter) {
        var counter = 0;
       for(int i = 0; i < s.Length; i++){
            if(s[i] == letter){
               counter++;
            }
        }
    return Convert.ToInt32(
        Math.Truncate(
            Convert.ToDouble(counter) / Convert.ToDouble(s.Length) * 100));

    }
}