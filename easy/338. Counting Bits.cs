public class Solution {
    public int[] CountBits(int n) {
        var result = new List<int>();

        for(var i = 0; i <= n; i++){
            var val = Convert.ToString(i, 2);

            result.Add(val.Where(x => x == '1').Count());
        }

        return result.ToArray();
    }
}

public class Solution {
    public int[] CountBits(int n) {
        var result = new int[n + 1];
        result[0] = 0;

        for (var i = 1; i <= n; i++) {
            result[i] = result[i >> 1] + (i & 1);
        }

        return result;
    }
}