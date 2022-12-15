public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        var result = 0;
        for(int i = 0; i < points.Length - 1; i++){
            var thisPoint = points[i];
            var nextPoint = points[i+1];
            var firstValue = thisPoint[0] - nextPoint[0] < 0 
                ? (thisPoint[0] - nextPoint[0]) * -1
                : thisPoint[0] - nextPoint[0];
            var secondValue = thisPoint[1] - nextPoint[1] < 0 
                ? (thisPoint[1] - nextPoint[1]) * -1
                : thisPoint[1] - nextPoint[1];
            result += firstValue > secondValue
                ? firstValue
                : secondValue;
        }
        return result;
    }
}