public class Solution {
    public IList<int> StableMountains(int[] height, int threshold) {
        var result = new List<int>();

        for(var i = 1; i < height.Length; i++){
            if(height[i - 1] > threshold)
                result.Add(i);
        }

        return result;
    }
}