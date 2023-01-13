public class Solution {
    public int HeightChecker(int[] heights) {
        var counter = 0;
        var correctArray = new int[heights.Length];
        Array.Copy(heights, correctArray,heights.Length);
        Array.Sort(correctArray);

        for(int i = 0; i < heights.Length; i++){
            counter += heights[i] == correctArray[i] ? 0 : 1;
        }
        return counter;
    }
}