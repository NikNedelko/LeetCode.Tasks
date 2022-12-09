public class Solution {
    public string SortSentence(string s) {
        var startPoint = s.Length - 1;
        var numberOfPlace = 0;
        var dict = new Dictionary<int, string>();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                dict.Add(numberOfPlace, s.Substring(i, startPoint - i + 1));
                break;
            }

            if (char.IsDigit(s[i]))
            {
                startPoint = i - 1;
                numberOfPlace = Convert.ToInt32(Convert.ToString(s[i]));
            }

            if (s[i] == ' ')
            {
                dict.Add(numberOfPlace, s.Substring(i + 1, startPoint - i));
            }
        }

        var array = dict.OrderBy(x => x.Key).Select(c=>c.Value).ToList();
        var result = "";
        for (int i = 0; i < array.Count; i++)
        {
            result += array[i];
            if (i+1!=array.Count)
            {
                result += " ";
            }
        }
        return result;
    }
}