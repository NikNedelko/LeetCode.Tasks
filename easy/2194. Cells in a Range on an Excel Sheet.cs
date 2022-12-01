public class Solution {
    public IList<string> CellsInRange(string s) {
        var result = new List<string>();
        var countOfNumbersInColumn = Convert.ToInt32(Convert.ToString(s[4]));
        for (int i = Convert.ToInt32(s[0]); i <= Convert.ToInt32(s[3]); i++)
        {
            for (int j = Convert.ToInt32(Convert.ToString(s[1])); j <= countOfNumbersInColumn; j++)
            {
                result.Add(Convert.ToString(Convert.ToChar(i)) + Convert.ToString(j));
            }
        }

        return result;
    }
}