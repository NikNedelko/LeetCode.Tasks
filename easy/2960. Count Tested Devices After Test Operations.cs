public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        var result = 0;
        var lessThan = 0;
        
        for(var i = 0; i < batteryPercentages.Length; i++){
            if(batteryPercentages[i] > lessThan){
                result++;
                lessThan++;
            }
        }

        return result;
    }
}

public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        var result = 0;

        for(var i = 0; i < batteryPercentages.Length; i++){
            if(batteryPercentages[i] > 0){
                result++;
                for(var j = i + 1; j < batteryPercentages.Length; j++){
                    batteryPercentages[j] = Math.Max(0, batteryPercentages[j] - 1);
                }
            }
        }

        return result;
    }
}