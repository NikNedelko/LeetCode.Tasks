public class Solution {
    public int CountCompleteDayPairs(int[] hours) {
        var result = 0;

        for(int i = 0; i < hours.Length; i++){
            for(int j = i + 1; j < hours.Length; j++){
                if((hours[i] + hours[j]) % 24 == 0)
                    result++;
            }
        }

        return result;
    }
}