public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        var result = 0;
        var arr = points.Select(x => x[0])
                        .OrderBy(x => x)
                        .ToArray();

        for(var i = 1; i < arr.Length; i++){
            var dif = arr[i] - arr[i - 1];

            if(dif < 0)
                dif *= -1;

            if(result < dif)
                result = dif;
        }

        return result;
    }
}

public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        var result = 0;
        var arr = points.OrderBy(x => x[0])
                        .ToArray();

        for(var i = 1; i < arr.Length; i++){
            var dif = arr[i][0] - arr[i - 1][0];

            if(dif < 0)
                dif *= -1;

            if(result < dif)
                result = dif;
        }

        return result;
    }
}