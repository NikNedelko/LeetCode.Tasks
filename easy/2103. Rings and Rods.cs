public class Solution {
    public int CountPoints(string rings) {
        var dict = new Dictionary<int, string>();
        for (int i = 0; i < rings.Length; i += 2)
        {
            if (dict.ContainsKey(Convert.ToInt32(Convert.ToString(rings[i + 1]))))
            {
                dict[Convert.ToInt32(Convert.ToString(rings[i + 1]))] += Convert.ToString(rings[i]);
            }
            else
            {
                dict.Add(Convert.ToInt32(Convert.ToString(rings[i + 1])), Convert.ToString(rings[i]));
            }
        }
        
        return dict.Select(
            i => i.Value.Contains("R")
                 && i.Value.Contains("G")
                 && i.Value.Contains("B")).Count(i=>i);
    }
}