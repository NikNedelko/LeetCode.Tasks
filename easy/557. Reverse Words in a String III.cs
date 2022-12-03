public class Solution {
    public string ReverseWords(string s) {
        var result = new StringBuilder();
        var preResult = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ' || i + 1 == s.Length)
            {
                if (s[i] == ' ') preResult.Append(s[i]);
                if (i + 1 == s.Length) preResult.Insert(0, s[i]);
                result.Append(preResult.ToString());
                preResult.Clear();
                continue;
            }
            preResult.Insert(0, s[i]);
        }

        return result.ToString();
    }
}