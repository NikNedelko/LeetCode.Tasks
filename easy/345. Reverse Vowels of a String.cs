public class Solution {

     private static readonly HashSet<char> Vowels = 
        new HashSet<char>("aeiouAEIOU".ToCharArray());

    public string ReverseVowels(string s) {
        var sb = new StringBuilder(s);

        for(int i = 0, j = sb.Length - 1; i < j;){
            if(!Vowels.Contains(sb[i])){
                i++;
                continue;
            }
            if(!Vowels.Contains(sb[j])){
                j--;
                continue;
            }

            sb[i]  = sb[j];
            sb[j]  = s[i];
            
            i++;
            j--;
        }

        return sb.ToString();
    }
}