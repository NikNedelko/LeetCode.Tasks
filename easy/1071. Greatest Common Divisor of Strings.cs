public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(str1 + str2 != str2 + str1)
            return "";

        var prefixLength = GCD(str1.Length, str2.Length);

        return str1.Substring(0, prefixLength);
    }

    private static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }   

    return a | b;
    }
}