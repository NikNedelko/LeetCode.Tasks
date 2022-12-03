public class Solution {
    public int CountAsterisks(string s) {
        var read = true;
        var counter = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]=='|')
               read = !read;
            if (s[i] == '*' && read)
                counter++;
        }

        return counter;
    }
}