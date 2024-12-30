public class Solution {
    public string ConvertDateToBinary(string date) {
        var arr = date.Split('-');
        var result = new StringBuilder();

        for(var i = 0; i < arr.Length; i++){
            if(i != 0)
                result.Append('-');
            
            result.Append(Convert.ToString(Convert.ToInt32((string)arr[i]), 2));
        }

        return result.ToString();
    }
}