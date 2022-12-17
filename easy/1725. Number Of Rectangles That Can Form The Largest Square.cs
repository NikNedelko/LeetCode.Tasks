public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        var dict = new Dictionary<int,int>();
        foreach(var rectangle in rectangles){
            if(dict.ContainsKey(rectangle.Min())){
                dict[rectangle.Min()]++;
            }
            else{
                dict.Add(rectangle.Min(),1);
            }
        }
        return dict.OrderByDescending(x => x.Key).FirstOrDefault().Value;
    }
}