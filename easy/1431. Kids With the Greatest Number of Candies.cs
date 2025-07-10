public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var max = candies[0];

        for(var i = 1; i < candies.Length; i++){
            if(candies[i] > max){
                max = candies[i];
            }
        }

        //var max = candies.Max(); but slower

        var result = new bool[candies.Length];

        for(var i = 0; i < candies.Length; i++){
            result[i] = candies[i] + extraCandies >= max;
        }

        return result;
    }
}