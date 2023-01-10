public class Solution {
    public bool DigitCount(string num) {
        var dict = new Dictionary<int,int>();

        for (int i = 0; i < num.Length; i++){
            if(!dict.ContainsKey(Convert.ToInt32(Convert.ToString(num[i]))))
                dict.Add(Convert.ToInt32(Convert.ToString(num[i])), 1);
            else
                dict[Convert.ToInt32(Convert.ToString(num[i]))]++;
        }

        for(int i = 0; i < num.Length; i++){
            if(!dict.ContainsKey(i) && Convert.ToInt32(Convert.ToString(num[i]))==0)
                continue;
            if (!dict.ContainsKey(i))
                return false;
            if(dict[i] == Convert.ToInt32(Convert.ToString(num[i])))
                continue;
            else 
                return false;
        }

        return true;
    }
}