public class Solution {
    public bool SquareIsWhite(string coordinates) {
        if(Convert.ToInt32(coordinates[0])%2==0){
            if(Convert.ToInt32(Convert.ToString(coordinates[1]))%2==0)
                return false;
            return true;
        }
        if(Convert.ToInt32(Convert.ToString(coordinates[1]))%2!=0){
                return false;
        }
        return true;
    }
}