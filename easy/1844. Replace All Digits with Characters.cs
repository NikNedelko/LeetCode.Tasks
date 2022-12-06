public class Solution {
    public string ReplaceDigits(string s) {
        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                var digit = Convert.ToInt32(Convert.ToString(s[i]));
                var letter = Convert.ToInt32(Convert.ToString(Convert.ToInt32(s[i - 1])));
                result += Convert.ToString(Convert.ToChar(letter + digit));
                continue;
            }

            result += Convert.ToString(s[i]);
        }

        return result;
    }
}