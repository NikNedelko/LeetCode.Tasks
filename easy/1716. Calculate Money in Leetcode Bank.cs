public class Solution {
    public int TotalMoney(int n) {
        var result = 0;
        
        var mult = 0;
        var moneyPerDay = 1;

        for(var i = 1; i <= n; i++){
            result += moneyPerDay + mult;
            moneyPerDay++;

            if(i % 7 == 0){
                moneyPerDay = 1;
                mult++;
            }
        }

        return result;
    }
}