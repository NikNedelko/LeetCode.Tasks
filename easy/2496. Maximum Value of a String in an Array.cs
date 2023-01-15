public class Solution {
    public int MaximumValue(string[] strs) {
        var list = new List<int>();
        foreach(var item in strs){
            var buf = 0;
            try{
                buf = Convert.ToInt32(item);
                list.Add(buf);
            }
            catch{
                list.Add(item.Length);
            }
        }
        return  list.Max();
    }
}