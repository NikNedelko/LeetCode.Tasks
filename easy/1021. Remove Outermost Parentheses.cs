public class Solution {
    public string RemoveOuterParentheses(string s) {
        var result = "";
        var edge = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (edge > 0)
                result += Convert.ToString(s[i]);

            if (s[i] == '(' && s[i+1] == '(') edge++;
            if (s[i] == ')' && s[i+1] == ')') edge--;
        }

        return result;
    }
}