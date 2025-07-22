public class Solution {
    public int MaxArea(int[] height) {
        var max = 0;
        int p1 = 0, p2 = height.Length - 1;

        while(p1 < p2){
            var volume = Math.Min(height[p1], height[p2]) * (p2 - p1);
            max = Math.Max(max, volume);

            if(height[p1] > height[p2]){
                p2--;
            }
            else{
                p1++;
            }
        }

        return max;
    }
}


//O(n^2)
public class Solution {
    public int MaxArea(int[] height) {
        var max = 0;

        for(var i = 0; i < height.Length; i++){
            for(var j = i + 1; j < height.Length; j++){
                var volume = Math.Min(height[i], height[j]) * (j - i);
                max = Math.Max(max, volume);
            }
        }

        return max;
    }
}